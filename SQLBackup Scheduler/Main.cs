using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SQLBackup_Scheduler
{
    public partial class Main : Form
    {
        Boolean error = false;
        public Main()
        {
            InitializeComponent();
        }

        public void createTask(String Nombre,String Folder,DaysOfTheWeek Days)
        {
            // Get the service on the local machine
            using (TaskService ts = new TaskService())
            {
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Crea respaldo de las Bases de Datos SQL Server.";;

                td.Triggers.Add(new WeeklyTrigger
                {
                    StartBoundary = Convert.ToDateTime(Hora.Value.ToString("hh:mm:ss tt")),
                    DaysOfWeek = Days
                });
    
                td.Actions.Add(new ExecAction(Folder, null));
                //td.Principal.LogonType = TaskLogonType.Group;
                //ClaveCompu.Text == "" ? null : ClaveCompu.Text
                ts.RootFolder.RegisterTaskDefinition(Nombre, td, TaskCreation.CreateOrUpdate, UsuarioCompu.Text, ClaveCompu.Text == "" ? null : ClaveCompu.Text, TaskLogonType.InteractiveTokenOrPassword);
            }
        }

        public void createTaskMensual(String Nombre, String Folder)
        {
            // Get the service on the local machine
            using (TaskService ts = new TaskService())
            {
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Crea respaldo de las Bases de Datos SQL Server.";

                td.Triggers.Add(new MonthlyTrigger
                {
                    StartBoundary = Convert.ToDateTime(Hora.Value.ToString("hh:mm:ss tt")),
                    MonthsOfYear = MonthsOfTheYear.AllMonths
                });

                td.Actions.Add(new ExecAction(Folder, null));

                ts.RootFolder.RegisterTaskDefinition(Nombre, td, TaskCreation.CreateOrUpdate,UsuarioCompu.Text,ClaveCompu.Text=="" ? null : ClaveCompu.Text);
            }
        }

        private void createBat(String Dia)
        {
            Directory.CreateDirectory(BackUpFolder.Text);
            Directory.CreateDirectory(BackUpFolder.Text+"\\Bat");
            Directory.CreateDirectory(BackUpFolder.Text+$"\\Diario\\{Dia}");
            File.WriteAllText($"{BackUpFolder.Text}\\Bat\\{Dia}.bat", $"sqlcmd -S {Instancia.Text} -E -Q \"EXEC sp_BackupDatabases @backupLocation = '{BackUpFolder.Text}\\Diario\\{Dia}\\', @backupType=\'F\'\"");
        }

        private void createBatMensual()
        {
            Directory.CreateDirectory(BackUpFolder.Text);
            Directory.CreateDirectory(BackUpFolder.Text + "\\Bat");
            Directory.CreateDirectory(BackUpFolder.Text + $"\\Mensual");
            String Comando = "FOR /F \"skip=1 tokens=1-6\" %%G IN ('WMIC Path Win32_LocalTime Get Day^,Hour^,Minute^,Month^,Second^,Year /Format:table') DO (\n" + Environment.NewLine +
                "   IF \"%%~L\"==\"\" goto s_done\n" + Environment.NewLine +
                "      Set year=%%L\n" + Environment.NewLine +
                "      Set month=00%%J\n" + Environment.NewLine +
                "      Set _dd=00%%G\n" + Environment.NewLine +
                "      Set _hour=00%%H\n" + Environment.NewLine +
                "      SET _minute=00%%I\n" + Environment.NewLine +
                ")\n" + Environment.NewLine +
                ":s_done\n" + Environment.NewLine +
                "\n" + Environment.NewLine +
                "echo %month%\n" + Environment.NewLine +
                "echo %year%\n" + Environment.NewLine +
                "set mes=mes\n" + Environment.NewLine +
                "\n" + Environment.NewLine +
                "IF \"%month%\" == \"002\" set mes=Enero\n" + Environment.NewLine +
                "IF \"%month%\" == \"003\" set mes=Febrero\n" + Environment.NewLine +
                "IF \"%month%\" == \"004\" set mes=Marzo\n" + Environment.NewLine +
                "IF \"%month%\" == \"005\" set mes=Abril\n" + Environment.NewLine +
                "IF \"%month%\" == \"006\" set mes=Mayo\n" + Environment.NewLine +
                "IF \"%month%\" == \"007\" set mes=Junio\n" + Environment.NewLine +
                "IF \"%month%\" == \"008\" set mes=Julio\n" + Environment.NewLine +
                "IF \"%month%\" == \"009\" set mes=Agosto\n" + Environment.NewLine +
                "IF \"%month%\" == \"010\" set mes=Septiembre\n" + Environment.NewLine +
                "IF \"%month%\" == \"011\" set mes=Octubre\n" + Environment.NewLine +
                "IF \"%month%\" == \"012\" set mes=Noviembre\n" + Environment.NewLine +
                "IF \"%month%\" == \"001\" set mes=Diciembre\n" + Environment.NewLine +
                $"mkdir \"{BackUpFolder.Text}\\Mensual\\%year%\\%mes%\\\"\n" + Environment.NewLine +
                "echo off"+Environment.NewLine+
                "cls"+Environment.NewLine+
                $"sqlcmd -S {Instancia.Text} -E -Q \"EXEC sp_BackupDatabases @backupLocation = '{BackUpFolder.Text}\\Mensual\\%year%\\%mes%\\', @backupType='F'\"\n" + Environment.NewLine;

            File.WriteAllText($"{BackUpFolder.Text}\\Bat\\Mensual.bat", Comando);
        }

        private void createProcedure()
        {
            error = false;
            SqlConnection connection = new SqlConnection($"Data Source={Instancia.Text};Initial Catalog=master;User ID={Usuario.Text};Password={Contra.Text}");
            String ProcedureQuery = "IF NOT EXISTS ( SELECT * \n" +
                "            FROM   sysobjects \n" +
                "            WHERE  id = object_id(N'[dbo].[sp_BackupDatabases]') \n" +
                "                   and OBJECTPROPERTY(id, N'IsProcedure') = 1 )\n" +
                "BEGIN\n" +
                "\n" +
                " \n" +
                "EXEC('CREATE PROCEDURE [dbo].[sp_BackupDatabases]  \n" +
                "            @databaseName sysname = null,\n" +
                "            @backupType CHAR(1),\n" +
                "            @backupLocation nvarchar(200) \n" +
                "AS \n" +
                "       SET NOCOUNT ON; \n" +
                "           \n" +
                "            DECLARE @DBs TABLE\n" +
                "            (\n" +
                "                  ID int IDENTITY PRIMARY KEY,\n" +
                "                  DBNAME nvarchar(500)\n" +
                "            )\n" +
                "            INSERT INTO @DBs (DBNAME)\n" +
                "            SELECT Name FROM master.sys.databases\n" +
                "            where state=0\n" +
                "            AND name=@DatabaseName\n" +
                "            OR @DatabaseName IS NULL\n" +
                "            ORDER BY Name\n" +
                "           \n" +
                "            -- Filter out databases which do not need to backed up\n" +
                "            IF @backupType=''F''\n" +
                "                  BEGIN\n" +
                "                  DELETE @DBs where DBNAME IN \n" +
                "(''tempdb'',''master'',''model'',''msdb'' )\n" +
                "                  END\n" +
                "            ELSE IF @backupType=''D''\n" +
                "                  BEGIN\n" +
                "                  DELETE @DBs where DBNAME IN \n" +
                "(''tempdb'',''master'',''model'',''msdb'' )\n" +
                "                  END\n" +
                "            ELSE IF @backupType=''L''\n" +
                "                  BEGIN\n" +
                "                  DELETE @DBs where DBNAME IN \n" +
                "(''tempdb'',''master'',''model'',''msdb'' )\n" +
                "                  END\n" +
                "            ELSE\n" +
                "                  BEGIN\n" +
                "                  RETURN\n" +
                "                  END\n" +
                "            -- Declare variables\n" +
                "            DECLARE @BackupName varchar(100)\n" +
                "            DECLARE @BackupFile varchar(100)\n" +
                "            DECLARE @DBNAME varchar(300)\n" +
                "            DECLARE @sqlCommand NVARCHAR(1000) \n" +
                "        DECLARE @dateTime NVARCHAR(20)\n" +
                "            DECLARE @Loop int                  \n" +
                "                       \n" +
                "            -- Loop through the databases one by one\n" +
                "            SELECT @Loop = min(ID) FROM @DBs\n" +
                " \n" +
                "      WHILE @Loop IS NOT NULL\n" +
                "      BEGIN\n" +
                " \n" +
                "-- Database Names have to be in [dbname] format since some have - or _ in their name\n" +
                "      SET @DBNAME = ''[''+(SELECT DBNAME FROM @DBs WHERE ID = @Loop)+'']''\n" +
                " \n" +
                "\n" +
                "      SET @dateTime = REPLACE(CONVERT(VARCHAR, GETDATE(),101),''/'','''') + ''_'' +  REPLACE(CONVERT(VARCHAR, GETDATE(),108),'':'','''')  \n" +
                " \n" +
                "\n" +
                "      IF @backupType = ''F''\n" +
                "            SET @BackupFile = @backupLocation+REPLACE(REPLACE(@DBNAME, ''['',''''),'']'','''')+ ''_FULL_''+''.BAK''\n" +
                "      ELSE IF @backupType = ''D''\n" +
                "            SET @BackupFile = @backupLocation+REPLACE(REPLACE(@DBNAME, ''['',''''),'']'','''')+ ''_DIFF_''+''.BAK''\n" +
                "      ELSE IF @backupType = ''L''\n" +
                "            SET @BackupFile = @backupLocation+REPLACE(REPLACE(@DBNAME, ''['',''''),'']'','''')+ ''_LOG_''+''.TRN''\n" +
                " \n" +
                "\n" +
                "      IF @backupType = ''F''\n" +
                "            SET @BackupName = REPLACE(REPLACE(@DBNAME,''['',''''),'']'','''') +'' full backup for ''+ @dateTime\n" +
                "      IF @backupType = ''D''\n" +
                "            SET @BackupName = REPLACE(REPLACE(@DBNAME,''['',''''),'']'','''') +'' differential backup for ''+ @dateTime\n" +
                "      IF @backupType = ''L''\n" +
                "            SET @BackupName = REPLACE(REPLACE(@DBNAME,''['',''''),'']'','''') +'' log backup for ''+ @dateTime\n" +
                " \n" +
                "\n" +
                " \n" +
                "       IF @backupType = ''F'' \n" +
                "                  BEGIN\n" +
                "               SET @sqlCommand = ''BACKUP DATABASE '' +@DBNAME+  '' TO DISK = ''''''+@BackupFile+ '''''' WITH INIT, NAME= '''''' +@BackupName+'''''', NOSKIP, NOFORMAT''\n" +
                "                  END\n" +
                "       IF @backupType = ''D''\n" +
                "                  BEGIN\n" +
                "               SET @sqlCommand = ''BACKUP DATABASE '' +@DBNAME+  '' TO DISK = ''''''+@BackupFile+ '''''' WITH DIFFERENTIAL, INIT, NAME= '''''' +@BackupName+'''''', NOSKIP, NOFORMAT''        \n" +
                "                  END\n" +
                "       IF @backupType = ''L'' \n" +
                "                  BEGIN\n" +
                "               SET @sqlCommand = ''BACKUP LOG '' +@DBNAME+  '' TO DISK = ''''''+@BackupFile+ '''''' WITH INIT, NAME= '''''' +@BackupName+'''''', NOSKIP, NOFORMAT''        \n" +
                "                  END\n" +
                " \n" +
                "\n" +
                "       EXEC(@sqlCommand)\n" +
                " \n" +
                "\n" +
                "SELECT @Loop = min(ID) FROM @DBs where ID>@Loop\n" +
                " \n" +
                "END')\n" +
                "END\n";

            try
            {
                SqlCommand command = new SqlCommand(ProcedureQuery, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                error = true;
            }
        }

        private void Programar_Click(object sender, EventArgs e)
        {
            createProcedure();

            if (!error)
            {
                if (Lunes.Checked)
                {
                    createTask($"RESPALDOS {Instancia.Text}\\Respaldo Lunes", BackUpFolder.Text + "\\Bat\\Lunes.bat", DaysOfTheWeek.Tuesday);
                    createBat("Lunes");
                }
                if (Martes.Checked)
                {
                    createTask($"RESPALDOS {Instancia.Text}\\Respaldo Martes", BackUpFolder.Text + "\\Bat\\Martes.bat", DaysOfTheWeek.Wednesday);
                    createBat("Martes");
                }
                if (Miercoles.Checked)
                {
                    createTask($"RESPALDOS {Instancia.Text}\\Respaldo Miercoles", BackUpFolder.Text + "\\Bat\\Miercoles.bat", DaysOfTheWeek.Thursday);
                    createBat("Miercoles");
                }
                if (Jueves.Checked)
                {
                    createTask($"RESPALDOS {Instancia.Text}\\Respaldo Jueves", BackUpFolder.Text + "\\Bat\\Jueves.bat", DaysOfTheWeek.Friday);
                    createBat("Jueves");
                }
                if (Viernes.Checked)
                {
                    createTask($"RESPALDOS {Instancia.Text}\\Respaldo Viernes", BackUpFolder.Text + "\\Bat\\Viernes.bat", DaysOfTheWeek.Saturday);
                    createBat("Viernes");
                }
                if (Sabado.Checked)
                {
                    createTask($"RESPALDOS {Instancia.Text}\\Respaldo Sabado", BackUpFolder.Text + "\\Bat\\Sabado.bat", DaysOfTheWeek.Sunday);
                    createBat("Sabado");
                }
                if (Domingo.Checked)
                {
                    createTask($"RESPALDOS {Instancia.Text}\\Respaldo Domingo", BackUpFolder.Text + "\\Bat\\Domingo.bat", DaysOfTheWeek.Monday);
                    createBat("Domingo");
                }
                if (Mensual.Checked)
                {
                    createTaskMensual($"RESPALDOS {Instancia.Text}\\Respaldo Mensual", BackUpFolder.Text + "\\Bat\\Mensual.bat");
                    createBatMensual();
                }
                MessageBox.Show("Se han programado los respaldos.","Respaldos Programados",MessageBoxButtons.OK,MessageBoxIcon.Information);
            } 
        }

        private void Todos_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Domingo_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void CheckAll()
        {
            if (Lunes.Checked && Martes.Checked && Miercoles.Checked && Jueves.Checked && Viernes.Checked && Sabado.Checked && Domingo.Checked)
                Todos.Checked = true;
            else
                Todos.Checked = false;
        }

        private void Sabado_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void Viernes_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void Jueves_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void Miercoles_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void Martes_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void Lunes_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void Todos_Click(object sender, EventArgs e)
        {
            if (Todos.Checked)
            {
                Lunes.Checked = true;
                Martes.Checked = true;
                Miercoles.Checked = true;
                Jueves.Checked = true;
                Viernes.Checked = true;
                Sabado.Checked = true;
                Domingo.Checked = true;
            }
            else
            {
                Lunes.Checked = false;
                Martes.Checked = false;
                Miercoles.Checked = false;
                Jueves.Checked = false;
                Viernes.Checked = false;
                Sabado.Checked = false;
                Domingo.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {

                    BackUpFolder.Text = folderDialog.SelectedPath;
                }
            }
        }
    }
}
