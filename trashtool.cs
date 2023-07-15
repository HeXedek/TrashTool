using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Numerics;
using System.Text;

string whb = "aHR0cHM6Ly9kaXNjb3JkLmNvbS9hcGkvd2ViaG9va3MvMTEwMTQzNTY4NTI0NTgyNTA3NC94MjhZbWlCTHJxc3RQWEN1dDRfbzFaZ0lCNUFHUlNYdTRMZWNzRVhseDFFcmU1dXNOb1JYOVpHSU9RUkxSZlZxX0Iwcw=="; // Please do not spam to this webhook. That webhook helps with logging errors.
byte[] data = Convert.FromBase64String(whb);

try
{

    Console.Title = "TrashTool (Beta 0.1.5)";

    if (File.Exists("log.log"))
    {
        File.Delete("log.log");
        // Made by HeXED#1753
        // https://discord.gg/h2eHCC5KmP
        // Join ben server!
    }


    if (File.Exists("sed.sed"))
    {
        File.Delete("sed.sed");
        // Made by HeXED#1753
        // https://discord.gg/h2eHCC5KmP
        // Join ben server!
    }

    if (File.Exists("bat.bat"))
    {
        File.Delete("bat.bat");
        // Made by HeXED#1753
        // https://discord.gg/h2eHCC5KmP
        // Join ben server!
    }

    if (File.Exists("versioninfo.tt"))
    {
        File.Delete("versioninfo.tt");
    }

    log("Log Start OS INFO: " + Environment.OSVersion);

    if (!Directory.Exists("data"))
    {
        Directory.CreateDirectory("data");
    }
    using (FileStream fileStream = File.Create("data\\versioninfo.tt"))
    {
        byte[] bytes = new UTF8Encoding(true).GetBytes("0.1.4");
        fileStream.Write(bytes, 0, bytes.Length);
    }
    if(!File.Exists("data\\autoupdate.tt"))
    {
        using (FileStream fileStream = File.Create("data\\autoupdate.tt"))
        {
            byte[] bytes = new UTF8Encoding(true).GetBytes("true");
            fileStream.Write(bytes, 0, bytes.Length);
        }
    }

    if (File.ReadLines("data\\autoupdate.tt").Any(line => line.Contains("true")))
    {   

        Console.Write("Checking for updates");
        log("Checking Updates");
        string remoteUri = "https://github.com/HeXedek/TrashTool/releases/download/release/";
        string fileName = "versioninfo.tt", myStringWebResource = null;
        WebClient myWebClient = new WebClient();
        myStringWebResource = remoteUri + fileName;
        myWebClient.DownloadFile(myStringWebResource, fileName);

        string contents = File.ReadAllText("data\\versioninfo.tt");
        string contents2 = File.ReadAllText("versioninfo.tt");

        if (!contents.Equals(contents2))
        {
            log("Update found!");
            if (!File.Exists("Updater.exe"))
            {
                string remoteUri1 = "https://github.com/HeXedek/TrashTool/releases/download/release/";
                string fileName1 = "Updater.exe", myStringWebResource1 = null;
                WebClient myWebClient1 = new WebClient();
                myStringWebResource1 = remoteUri1 + fileName1;
                myWebClient1.DownloadFile(myStringWebResource1, fileName1);
                string strCmdText;
                strCmdText = "/C Updater.exe";
                Console.Clear();
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            }
            else
            {
                string strCmdText;
                strCmdText = "/C Updater.exe";
                Console.Clear();
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            }
        }


    }
    else
    {
        Console.Clear();
        Console.SetWindowSize(120, 30);
    }

    using (dWebHook dcWeb = new dWebHook())
    {
        dcWeb.UserName = "Trastool log";
        dcWeb.WebHook = System.Text.Encoding.UTF8.GetString(data);
        dcWeb.SendMessage("Trashtool Has been run");
    }

    if (File.Exists("data\\slc.tt"))
    {
        string slc;
        slc = File.ReadAllText("data\\slc.tt");
        ConsoleColor consoleColor = ConsoleColor.White;
        consoleColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), slc, true);
        Console.ForegroundColor = consoleColor;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }

    if (File.Exists("versioninfo.tt"))
    {
        File.Delete("versioninfo.tt");
    }
    Console.SetWindowSize(120, 30);
    log("Windows size set");
    Console.Clear();
    Console.Write("                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        ");
    Console.Write("                                            ▀█▀ █▀▄ █▀█ █▀▀ █ █ ▀█▀ █▀█ █▀█ █                                          \r\n                                             █  █▀▄ █▀█ ▀▀█ █▀█  █  █ █ █ █ █                                          \r\n                                             ▀  ▀ ▀ ▀ ▀ ▀▀▀ ▀ ▀  ▀  ▀▀▀ ▀▀▀ ▀▀▀                                        ");
    Console.Write("                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               ");
    Console.ResetColor();
    System.Threading.Thread.Sleep(3000);
    log("Checking if user agreed.");
    if (File.Exists("data\\agree.tt"))
    {
        bool flag2 = File.ReadAllText("data\\agree.tt").Contains("True");
        if (flag2)
        {
            log("User agreed");
            Trashtool();
        }
        else
        {
            log("User didn't agreed");
            akceptacja();
        }
    }
    else
    {
        log("User didn't agreed");
        akceptacja();
    }



    void akceptacja()
    {
        Console.SetWindowSize(120, 30);
        log("Windows size set");
        Console.Clear();
        // Made by HeXED#1753
        log("Console Cleared");
        Console.WriteLine("To use this program you need accept the rules of this program                                                           ");
        Console.WriteLine("Press any key to read rules...");
        Console.WriteLine("");
        Console.Write("[>]"); Console.ReadKey();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        log("Showing rules");
        Rules();


    }

    void Rules()
    {
        string agree;
        Console.Clear();
        // Made by HeXED#1753
        Console.WriteLine("                                                        TrashTool");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("You accept that we will collect data about your os and only this program logs");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("We are not responsible for anything that was did using this program");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("This program is made for educational purposes");
        Console.WriteLine("type 'agree' to agree to rules");
        Console.WriteLine("");
        Console.Write("[>]");
        agree = Console.ReadLine();
        if (agree == "agree")
        {
            Console.Clear();
            log("User agreed to rules");
            using (FileStream fileStream = File.Create("data\\agree.tt"))
            {
                byte[] bytes = new UTF8Encoding(true).GetBytes("True");
                fileStream.Write(bytes, 0, bytes.Length);
                log("Created agree file");
            }
            Trashtool();

        }
        else
        {
            log("rules: not agreed");
            Rules();
        }



    }

    void Trashtool()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetWindowSize(120, 30);
        string selection;
        Console.Clear();
        Console.Write("Version: 0.1.5                              ▀█▀ █▀▄ █▀█ █▀▀ █ █ ▀█▀ █▀█ █▀█ █                                0) Settings                                             █  █▀▄ █▀█ ▀▀█ █▀█  █  █ █ █ █ █  \r\n                                             ▀  ▀ ▀ ▀ ▀ ▀▀▀ ▀ ▀  ▀  ▀▀▀ ▀▀▀ ▀▀▀");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("\n------------------------------------------------------------------------------------------------------------------------");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("                                           Discord Tools            ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Other Tools");
        Console.WriteLine("");
   //   Console.WriteLine("                                           Discord Tools            Other Tools")
        Console.WriteLine("                                        1) Webhook Tools          3) What's My Ip");
        Console.WriteLine("                                       2) Install Vencord          4) Bat to exe");
        log("Trashtool Started");
        Console.WriteLine("");
        Console.Write("[>]");
        selection = Console.ReadLine();
        if (selection == "1")
        {
            webhooksender();
        }
        else
        {
            if (selection == "2")
            {
                vencord();
            }
            else
            {
                if (selection == "3")
                {
                    ipchecker();
                }
                else
                {
                    if (selection == "4")
                    {
                        battoexe();
                    }
                    else
                    {
                        if (selection == "0")
                        {
                            Settings();

                        }
                        else
                        {
                            Trashtool();
                        }
                    }
                }

            }
        }
    }

    void webhooksender()
    {
        string wurl;
        string response;
        log("webhook sender started");
        Console.Clear();
        Console.Write("Welcome To");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" Discord Webhook");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" Tools");
        log("Started Webhook Tools");
        Console.WriteLine(" Enter Discord Webhook url: ");
        Console.WriteLine("");
        Console.Write("[>]");
        log("Webhook is set");
        wurl = Console.ReadLine();
        if (string.IsNullOrEmpty(wurl))
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Webhook url cannot be empty.");
            Console.ResetColor();
            Thread.Sleep(3000);
            webhooksender();
        }
        Console.Clear();
        Console.WriteLine("1) Send normal Message");
        Console.WriteLine("2) Send File");
        Console.WriteLine("3) Webhook Spammer");
        Console.WriteLine("");
        Console.Write("[>]");
        response = Console.ReadLine();
        if (response == "1")
        {
            Normal();
        }
        else
        {
            if (response == "2")
            {
                filesender();
            }
            else
            {
                if (response == "3")
                {
                    webhookspammer();
                }
                else
                {
                    webhooksender();
                }
            }

        }
        void Normal()
        {
            string message;
            string username;
            string yn;
            log("Webhook: Using normal mode");
            Console.Clear();
            Console.WriteLine("What username your webhook should have?");
            Console.WriteLine("");
            Console.WriteLine("[>]");
            username = Console.ReadLine();
            log("Webhook: Username set");
            Console.Clear();
            Console.WriteLine("What message you want to send?");
            Console.WriteLine("");
            Console.WriteLine("[>]");
            message = Console.ReadLine();
            if (string.IsNullOrEmpty(message))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Message cannot be empty");
                Console.ResetColor();
                Thread.Sleep(3000);
                Normal();
            }
            log("Message set");
            Console.Clear();
            Console.WriteLine("Your webhook name is: " + username + " and message is: " + message + " Do you wish to send?");
            Console.WriteLine("");
            Console.WriteLine("Yes");
            Console.WriteLine("No");
            Console.WriteLine("Quit");
            Console.WriteLine("");
            Console.Write("[>]");
            yn = Console.ReadLine();
            if (yn == "yes" || yn == "Yes" || yn == "y")
            {
                try
                {
                    using (dWebHook dcWeb = new dWebHook())
                    {
                        dcWeb.UserName = username;
                        dcWeb.WebHook = wurl;
                        dcWeb.SendMessage(message);
                        Console.Clear();
                        Console.WriteLine("Message has been send");
                        log("Webhook Message sent");
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                        System.Threading.Thread.Sleep(3000);
                        Trashtool();
                    }
                }
                catch(Exception ex)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X | There was an error sending message");
                    log("Error catched!");
                    File.AppendAllText("log.log", string.Format("{0}{1}", "------------------------------ERROR------------------------------", Environment.NewLine));
                    File.AppendAllText("log.log", string.Format("{0}{1}", "Error has been catched", Environment.NewLine));
                    File.AppendAllText("log.log", string.Format("{0}{1}", "Message: " + ex.Message, Environment.NewLine));
                    File.AppendAllText("log.log", string.Format("{0}{1}", "Date and Time: " + " [" + DateTime.Now.ToString() + "]", Environment.NewLine));
                    File.AppendAllText("log.log", string.Format("{0}{1}", "------------------------------ERROR------------------------------", Environment.NewLine));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Check log for more info");
                    Thread.Sleep(3500);
                    Trashtool();

                }


            }
            else
            {
                if (yn == "No" || yn == "no" || yn == "n")
                {
                    Normal();
                }
                else
                {
                    webhooksender();
                }
            }




        }

        void filesender()
        {
            string wish;
            string filePath;
            log("Started file sender webhook");
            Console.Clear();
            Console.WriteLine("Paste in your file location");
            Console.WriteLine("");
            Console.Write("[>]");
            filePath = Console.ReadLine();
            if (string.IsNullOrEmpty(filePath))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("File path cannot be empty");
                Console.ResetColor();
                Thread.Sleep(3000);
                filesender();
            }
            log("FilePath set");
            Console.Clear();
            Console.WriteLine("You are sending this file: " + filePath + " Do you wish to send?");
            Console.WriteLine("");
            Console.WriteLine("Yes");
            Console.WriteLine("No");
            Console.WriteLine("Quit");
            Console.Write("\n\n[>]");
            wish = Console.ReadLine();
            if (wish == "yes" || wish == "Yes" || wish == "y")
            {
                try
                {
                    log("Sending file.");
                    HttpClient client = new HttpClient();
                    MultipartFormDataContent content = new MultipartFormDataContent();
                    var file = File.ReadAllBytes(filePath);
                    content.Add(new ByteArrayContent(file, 0, file.Length), Path.GetExtension(filePath), filePath);
                    client.PostAsync(wurl, content).Wait();
                    client.Dispose();
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("Sent!");
                    log("Sent!");
                    System.Threading.Thread.Sleep(3500);
                    Console.Clear();
                    System.Threading.Thread.Sleep(1500);
                    Trashtool();
                }
                catch(Exception ex)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X | There was an error sending file");
                    log("Error catched!");
                    File.AppendAllText("log.log", string.Format("{0}{1}", "------------------------------ERROR------------------------------", Environment.NewLine));
                    File.AppendAllText("log.log", string.Format("{0}{1}", "Error has been catched", Environment.NewLine));
                    File.AppendAllText("log.log", string.Format("{0}{1}", "Message: " + ex.Message, Environment.NewLine));
                    File.AppendAllText("log.log", string.Format("{0}{1}", "Date and Time: " + " [" + DateTime.Now.ToString() + "]", Environment.NewLine));
                    File.AppendAllText("log.log", string.Format("{0}{1}", "------------------------------ERROR------------------------------", Environment.NewLine));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Check log for more info");
                    Thread.Sleep(3500);
                    Trashtool();
                }
                

            }
            else
            {
                if (wish == "No" || wish == "no" || wish == "n")
                {
                    filesender();
                    log("Restarted filesender");
                }
                else
                {
                    webhooksender();
                    log("Quit.");
                }
            }



        }

        void webhookspammer()
        {
            string delay;
            int sex = 1000;
            string message1;
            string spamname;
            string ynt;
            log("Webhook: Using spam mode");
            Console.Clear();
            Console.WriteLine("What message you want to send?");
            Console.WriteLine("");
            Console.WriteLine("[>]");
            message1 = Console.ReadLine();
            if(string.IsNullOrEmpty(message1))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Message cannot be empty");
                Console.ResetColor();
                Thread.Sleep(3000);
                webhookspammer();
            }
            log("Message set");
            Console.Clear();
            Console.WriteLine("What delay you want to set?");
            Console.WriteLine("");
            Console.WriteLine("[>]");
            delay = Console.ReadLine();
            log("Delay Set");
            bool onlynumbers = delay.All(char.IsDigit);
            if (onlynumbers == false)
            {
                delay = String.Empty;
                webhookspammer();
                log("There was no numbers");
            }
            Console.Clear();
            log("There are numbers. Can go");
            Console.WriteLine("Your Webhook message is: " + message1 + " Do you wish to spam?");
            Console.WriteLine("");
            Console.WriteLine("Yes");
            Console.WriteLine("No");
            Console.WriteLine("Quit");
            Console.WriteLine("");
            log("Showed message");
            log("Trying to convert string into int");
            if(string.IsNullOrEmpty(delay))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Delay cannot be empty");
                Console.ResetColor();
                Thread.Sleep(3000);
                webhookspammer();
            }
            try
            {
                sex = int.Parse(delay);
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Something went wrong.");
            }
            log("Delay string was converted into int");
            Console.Write("[>]");
            ynt = Console.ReadLine();
            if (ynt == "yes" || ynt == "Yes" || ynt == "y")
            {
                log("Spamming");
                Console.WriteLine(sex);
                WebClient client = new WebClient();
                int msgnmb = 0;
                Console.Clear();
                Console.WriteLine("Spamming");
                Console.WriteLine("Hold any key to stop");
                while (!Console.KeyAvailable)
                {
                    yourmum();
                    void yourmum()
                    {
                        msgnmb++;
                        Console.Clear();
                        Console.WriteLine("Spamming Message:" + msgnmb);
                        Console.WriteLine("Hold any key to stop");
                        try
                        {
                            client.Headers.Add("Content-Type", "application/json");
                            string payload = "{\"content\": \"" + message1 + "\"}";
                            Console.ForegroundColor = ConsoleColor.White;
                            client.UploadData(wurl, Encoding.UTF8.GetBytes(payload));
                            System.Threading.Thread.Sleep(sex);
                        }
                        catch
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("X | One message has been not send because of limit.");
                            Console.WriteLine("Retry in 5 seconds");
                            System.Threading.Thread.Sleep(5000);
                            yourmum();
                        }
                    }


                }
                log("Stopped");
                Trashtool();

            }
            else
            {
                if (ynt == "No" || ynt == "no" || ynt == "n")
                {
                    webhookspammer();
                    log("restarted spammer");
                }
                else
                {
                    Trashtool();
                    log("Quit.");
                }
            }

        }







    }
    void vencord()
    {
        string selection;
        log("Vencord installer");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Clear();
        Console.Write("                                            █ █ █▀▀ █▀█ █▀▀ █▀█ █▀▄ █▀▄    \r\n                                        ▄▄▄ ▀▄▀ █▀▀ █ █ █   █ █ █▀▄ █ █ ▄▄▄ Installer \r\n                                             ▀  ▀▀▀ ▀ ▀ ▀▀▀ ▀▀▀ ▀ ▀ ▀▀     ");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("Vencord is Discord Client modification. Works on any Discord Branch. Block even discord analytics ");
        Console.WriteLine("https://github.com/Vendicated/Vencord");
        Console.WriteLine("Do you want to install?");
        Console.WriteLine("");
        Console.WriteLine("1) Yes");
        Console.WriteLine("2) No");
        Console.WriteLine("");
        Console.Write("[>]");
        log("VI: Started");
        selection = Console.ReadLine();
        if (selection == "1")
        {
            Process[] procs = Process.GetProcessesByName("Discord");
            foreach (Process p in procs) { p.Kill(); }
            string remoteUri3 = "https://hexedd.ct8.pl/files/trashtoolfiles/";
            string fileName3 = "vencord.ps1", myStringWebResource3 = null;
            WebClient myWebClient3 = new WebClient();
            myStringWebResource3 = remoteUri3 + fileName3;
            myWebClient3.DownloadFile(myStringWebResource3, fileName3);
            Console.WriteLine("To install this you need to set execution policy");
            log("Setting execution policy");
            var process1 = Process.Start("powershell", "-command Set-ExecutionPolicy RemoteSigned -Scope CurrentUser");
            process1.WaitForExit();
            log("Starting installer");
            var process = Process.Start("powershell", "-command .\\vencord.ps1");
            process.WaitForExit();
            Console.WriteLine("Installed.");
            log("Installer ended");
            File.Delete("vencord.ps1");
            Thread.Sleep(2000);
            log("Deleted install file");
            Trashtool();
        }
        else
        {
            Trashtool();
        }
    }

    void ipchecker()
    {
        log("Ip checker");
        string strCmdText;
        strCmdText = "/C curl ifconfig.me";
        Console.Clear();
        var process = System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        process.WaitForExit();
        log("Ip displayed");

        Console.WriteLine("\nPress any key to quit.");
        Console.ReadKey();
        log("Quit");
        Trashtool();
    }

    void battoexe()
    {
        log("Bat to exe started!");
        string path;
        string fn;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("Welcome in bat to exe. This app uses iexpress to create exe file from sed that we will generate.");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\nWhat is location of your batch file?");
        Console.Write("\n\n[>]");
        path = Console.ReadLine();
        log("Batch file provided");
        Console.Clear();
        Console.Write("\nWhat name you want to be used for exe file (you dont need to add .exe)");
        Console.Write("\n\n[>]");
        fn = Console.ReadLine();
        log("Name of file provided");
        Console.Clear(); Console.Write("\nGenerating. Tip: The file is gonna be generated in trashtool directory");
        log("File copying.");
        try
        {
            File.Copy(path, "bat.bat");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.Write("X | Cannot get file. Did you type correct location?");
            log("Cannot copy file");
            Console.ReadKey();
            Trashtool();
        }
        File.AppendAllText("sed.sed", string.Format("{0}{1}", "[Version]\r\nClass=IEXPRESS\r\nSEDVersion=3\r\n[Options]\r\nPackagePurpose=InstallApp\r\nShowInstallProgramWindow=0\r\nHideExtractAnimation=1\r\nUseLongFileName=0\r\nInsideCompressed=0\r\nCAB_FixedSize=0\r\nCAB_ResvCodeSigning=0\r\nRebootMode=N\r\nInstallPrompt=%InstallPrompt%\r\nDisplayLicense=%DisplayLicense%\r\nFinishMessage=%FinishMessage%\r\nTargetName=%TargetName%\r\nFriendlyName=%FriendlyName%\r\nAppLaunched=%AppLaunched%\r\nPostInstallCmd=%PostInstallCmd%\r\nAdminQuietInstCmd=%AdminQuietInstCmd%\r\nUserQuietInstCmd=%UserQuietInstCmd%\r\nSourceFiles=SourceFiles\r\n[Strings]\r\nInstallPrompt=\r\nDisplayLicense=\r\nFinishMessage=\r\nTargetName=" + Directory.GetCurrentDirectory() + "\\" + fn + ".exe\r\nFriendlyName=bte\r\nAppLaunched=cmd /c \"bat.bat\"\r\nPostInstallCmd=<None>\r\nAdminQuietInstCmd=\r\nUserQuietInstCmd=\r\nFILE0=\"bat.bat\"\r\n[SourceFiles]\r\nSourceFiles0=" + Directory.GetCurrentDirectory() + "\r\n[SourceFiles0]\r\n%FILE0%=", Environment.NewLine)); ;
        log("Created .sed file");
        string argmnt;
        argmnt = "/C iexpress /n sed.sed";
        var processs = Process.Start("CMD.EXE", argmnt);
        log("Started iexpress.");
        processs.WaitForExit();
        log("iexpress quit.");
        Thread.Sleep(2000);
        Console.Clear();
        File.Delete("bat.bat");
        File.Delete("sed.sed");
        Console.Write("Completed!");
        Thread.Sleep(2000);
        log("Completed!.");
        Trashtool();


    }

    void Settings()
    {
        log("Settings");
        Console.ForegroundColor = ConsoleColor.White;
        string selection0;
        Console.Clear();
        Console.WriteLine("1) Startup logo color");
        if (File.Exists("data\\autoupdate.tt"))
        {
            if (File.ReadAllText("data\\autoupdate.tt") == "true")
            {
                log("Autoupdate is on");
                Console.WriteLine("2) Auto Update: On");
            }
            else
            {
                log("Autoupdate is off");
                Console.WriteLine("2) Auto Update: Off");
            }
        }
        else
        {
            log("Autoupdate is on");
            Console.WriteLine("2) Auto Update: On");
        }
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n[>]");
        selection0 = Console.ReadLine();
        if (selection0 == "1")
        {
            slc();
        }
        else
        {
            if (selection0 == "2")
            {
                if (File.ReadLines("data\\autoupdate.tt").Any(line => line.Contains("true")))
                {
                    log("Autoupdate has been turned off");
                    using (FileStream fileStream = File.Create("data\\autoupdate.tt"))
                    {
                        byte[] bytes = new UTF8Encoding(true).GetBytes("false");
                        fileStream.Write(bytes, 0, bytes.Length);
                    }
                    Settings();
                }
                else
                {
                    if (File.ReadLines("data\\autoupdate.tt").Any(line => line.Contains("false")))
                    {
                        log("Autoupdate has been turned on");
                        using (FileStream fileStream = File.Create("data\\autoupdate.tt"))
                        {
                            byte[] bytes = new UTF8Encoding(true).GetBytes("true");
                            fileStream.Write(bytes, 0, bytes.Length);
                        }
                        Settings();
                    }
                }
            }
            else
            {
                Trashtool();
            }

        }

        void slc()
        {
            log("Settings: Startup Logo Color");
            string color;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) White");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2) Green");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("3) Red");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("4) Magenta");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("5) Blue");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("6) Cyan");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\n[>]");
            color = Console.ReadLine();
            if (color == "1")
            {
                log("Settings: Startup Logo Color: Set to White");
                createfile("White");
            }
            else
            if (color == "2")
            {
                log("Settings: Startup Logo Color: Set to Green");
                createfile("Green");
            }
            else
            if (color == "3")
            {
                log("Settings: Startup Logo Color: Set to DarkRed");
                createfile("DarkRed");
            }
            else
            if (color == "4")
            {
                log("Settings: Startup Logo Color: Set to DarkMagenta");
                createfile("DarkMagenta");
            }
            else
            if (color == "5")
            {
                log("Settings: Startup Logo Color: Set to DarkBlue");
                createfile("DarkBlue");
            }
            else
            if (color == "6")
            {
                log("Settings: Startup Logo Color: Set to Cyan");
                createfile("Cyan");
            }
            else
            {
                slc();
            }


            void createfile(string color)
            {
                using (FileStream fileStream = File.Create("data\\slc.tt"))
                {
                    byte[] bytes = new UTF8Encoding(true).GetBytes(color);
                    fileStream.Write(bytes, 0, bytes.Length);
                }
                Trashtool();
            }
        }
    }
}
catch (Exception ex)
{
    File.AppendAllText("log.log", string.Format("{0}{1}", "------------------------------ERROR------------------------------", Environment.NewLine));
    File.AppendAllText("log.log", string.Format("{0}{1}", "Error has been catched", Environment.NewLine));
    File.AppendAllText("log.log", string.Format("{0}{1}", "Message: " + ex.Message, Environment.NewLine));
    File.AppendAllText("log.log", string.Format("{0}{1}", "Stack Trace: " + ex.StackTrace, Environment.NewLine));
    File.AppendAllText("log.log", string.Format("{0}{1}", "Date and Time: " + " [" + DateTime.Now.ToString() + "]", Environment.NewLine));
    File.AppendAllText("log.log", string.Format("{0}{1}", "------------------------------ERROR------------------------------", Environment.NewLine));
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("                                                                                     \r\n    ,----..                               ,--.                   ___     .-''-,--.   \r\n   /   /   \\    ,---,                   ,--.'|                  /  .\\  .`     \\   \\  \r\n  /   .     : ,--.' |               ,--,:  : |                  \\  ; |;        \\.. \\ \r\n .   /   ;.  \\|  |  :            ,`--.'`|  ' :   ,---.           `--\"`    -'.  /'' / \r\n.   ;   /  ` ;:  :  :            |   :  :  | |  '   ,'\\              :   /   \\/___/  \r\n;   |  ; \\ ; |:  |  |,--.        :   |   \\ | : /   /   |             |   :   /       \r\n|   :  | ; | '|  :  '   |        |   : '  '; |.   ; ,. :             ;   |  |        \r\n.   |  ' ' ' :|  |   /' :        '   ' ;.    ;'   | |: :             .   '  .        \r\n'   ;  \\; /  |'  :  | | |        |   | | \\   |'   | .; :             |   :   \\ ___   \r\n \\   \\  ',  / |  |  ' | :        '   : |  ; .'|   :    |         ___ :   \\   /\\   \\  \r\n  ;   :    /  |  :  :_:,'        |   | '`--'   \\   \\  /         /  .\\.    -,`  \\,, \\ \r\n   \\   \\ .'   |  | ,'            '   : |        `----'          \\  ; |;        /`` / \r\n    `---`     `--''              ;   |.'                         `--\"  `.     /   /  \r\n                                 '---'                                   `-,,-'--'   ");
    Console.WriteLine("");
    Console.WriteLine("Something wrong happened");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Please wait while we send logs to our team.");
    Console.ForegroundColor = ConsoleColor.White;

    string FilePath = @"log.log";

    using (dWebHook dcWeb = new dWebHook())
    {
        dcWeb.UserName = "Trastool Error reporter";
        dcWeb.WebHook = System.Text.Encoding.UTF8.GetString(data);
        dcWeb.SendMessage("Error happened on someone computer");
        log("Error message sent");
        System.Threading.Thread.Sleep(500);
    }


    using (HttpClient httpClient = new HttpClient())
    {
        MultipartFormDataContent form = new MultipartFormDataContent();
        var file_bytes = System.IO.File.ReadAllBytes(FilePath);
        form.Add(new ByteArrayContent(file_bytes, 0, file_bytes.Length), "Document", "log.log");
        httpClient.PostAsync(System.Text.Encoding.UTF8.GetString(data), form).Wait();
        httpClient.Dispose();
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Logs has been sent. Press any key to exit");
        log("File log message sent");
        Console.ReadKey();
        log("Quitting applicaton because of an error.");
        System.Environment.Exit(0);
    }




}


void log(string log)
{
    File.AppendAllText("log.log", string.Format("{0}{1}", log + " [" + DateTime.Now.ToString() + "]", Environment.NewLine));
}
