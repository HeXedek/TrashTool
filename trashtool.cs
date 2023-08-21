using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Numerics;
using System.Text;

try
{
    int devbuildint = 0;
    string build = "Version 0.3";

    if (devbuildint == 1)
    {
        if (!File.Exists("data\\dbuild.tt"))
        {
            using (FileStream fileStream = File.Create("data\\dbuild.tt"))
            {
                byte[] bytes = new UTF8Encoding(true).GetBytes("1");
                fileStream.Write(bytes, 0, bytes.Length);
            }
        }

        string devbuild = File.ReadAllText("data\\dbuild.tt");
        int x = Int32.Parse(devbuild);

        build = "DEV BUILD: 23" + DateTime.Today.DayOfYear + x++;

        int y = x++;

        using (FileStream fileStream = File.Create("data\\dbuild.tt"))
        {
            byte[] bytes = new UTF8Encoding(true).GetBytes(y.ToString());
            fileStream.Write(bytes, 0, bytes.Length);
        }

        Console.Title = "TrashTool " + build;
    }

    ConsoleColor consoleColor = ConsoleColor.White;
    string slc;

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
        byte[] bytes = new UTF8Encoding(true).GetBytes("0.3");
        fileStream.Write(bytes, 0, bytes.Length);
    }
    if (!File.Exists("data\\autoupdate.tt"))
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
            Console.Clear();
            Console.WriteLine("Preparing for update...");
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


    if (File.Exists("data\\slc.tt"))
    {
        slc = File.ReadAllText("data\\slc.tt");
        consoleColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), slc, true);
        Console.ForegroundColor = consoleColor;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
    }

    if (File.Exists("versioninfo.tt"))
    {
        File.Delete("versioninfo.tt");
    }
    Console.SetWindowSize(120, 30);
    if (devbuildint == 1)
    {
        System.Threading.Thread.Sleep(1);
        Trashtool();
    }
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
        Console.ForegroundColor = ConsoleColor.White;
        Console.ForegroundColor = consoleColor;
        Console.Write("\n\n\n\n\n\n\n\n                                            ▀█▀ █▀▄ █▀█ █▀▀ █ █ ▀█▀ █▀█ █▀█ █                               ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ForegroundColor = consoleColor;
        Console.Write("\n                                             █  █▀▄ █▀█ ▀▀█ █▀█  █  █ █ █ █ █                                          \n                                             ▀  ▀ ▀ ▀ ▀ ▀▀▀ ▀ ▀  ▀  ▀▀▀ ▀▀▀ ▀▀▀                                        ");
        Console.ForegroundColor= ConsoleColor.White;
        Console.Write("                                                        " + build);
        Console.ResetColor();
        Console.ForegroundColor = consoleColor;
        Console.Write("\n            Discord Tools                              Other Tools                            TrashTool");
        Console.ResetColor();
        Console.WriteLine("\n┌─────────────────────────────────────┬────────────────────────────────────────┬──────────────────────────────────────┐");
        Console.Write("│");
        Console.ForegroundColor = consoleColor;
        Console.Write("        [01] ");
        Console.ResetColor();
        Console.Write("Webhook Tools           │            ");
        Console.ForegroundColor = consoleColor;
        Console.Write("[03] ");
        Console.ResetColor();
        Console.Write("What's my IP           │           ");
        Console.ForegroundColor = consoleColor;
        Console.Write("[08] ");
        Console.ResetColor();
        Console.Write("Main color            │");
        Console.Write("\n│");
        Console.ForegroundColor = consoleColor;
        Console.Write("        [02]");
        Console.ResetColor();
        Console.Write(" Vencord Installer       │            ");
        Console.ForegroundColor = consoleColor;
        Console.Write("[04]");
        Console.ResetColor();
        Console.Write(" Bat to Exe             │           ");
        Console.ForegroundColor = consoleColor;
        Console.Write("[09]");
        Console.ResetColor();

        if (File.Exists("data\\autoupdate.tt"))
        {
            if (File.ReadAllText("data\\autoupdate.tt") == "true")
            {
                log("Autoupdate is on");
                Console.Write(" Auto Update: On       │");
            }
            else
            {
                log("Autoupdate is off");
                Console.Write(" Auto Update: Off      │");
            }
        }
        else
        {
            log("Autoupdate is on");
            Console.Write(" Auto Update: On");
        }
        Console.Write("\n│                                     │                                        │                                      │");
        Console.Write("\n│                                     │                                        │                                      │");
        Console.Write("\n│                                     │                                        │                                      │");
        Console.Write("\n│                                     │                                        │                                      │");
        Console.Write("\n│                                     │                                        │                                      │");
        Console.Write("\n│                                     │                                        │                                      │");
        Console.Write("\n│                                     │                                        │                                      │");
        Console.Write("\n└─────────────────────────────────────┴────────────────────────────────────────┴──────────────────────────────────────┘");


        Console.ForegroundColor = consoleColor;
        Console.Write("\n\n\n\n\n\n[>]");
        selection = Console.ReadLine();
        if (selection == "1" || selection == "01")
        {
            webhooksender();
        }
        else
        {
            if (selection == "2" || selection == "02")
            {
                vencord();
            }
            else
            {
                if (selection == "3" || selection == "03")
                {
                    ipchecker();
                }
                else
                {
                    if (selection == "4" || selection == "04")
                    {
                        battoexe();
                    }
                    else
                    {
                        if (selection == "8" || selection == "08")
                        {
                            maincolor();
                        }
                        else
                        {
                            if (selection == "9" || selection == "09")
                            {
                                if (File.ReadLines("data\\autoupdate.tt").Any(line => line.Contains("true")))
                                {
                                    log("Autoupdate has been turned off");
                                    using (FileStream fileStream = File.Create("data\\autoupdate.tt"))
                                    {
                                        byte[] bytes = new UTF8Encoding(true).GetBytes("false");
                                        fileStream.Write(bytes, 0, bytes.Length);
                                    }
                                    Trashtool();
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
                                        Trashtool();
                                    }
                                }
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
    }

    void webhooksender()
    {
        string wurl;
        string response;
        log("Webhook sender started");
        Console.Clear();
        log("Started Webhook Tools");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("                                                        Enter Url");
        Console.ForegroundColor = consoleColor;
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
        Console.ForegroundColor = consoleColor;
        Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n                                                     1)");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" Send Message");
        Console.ForegroundColor = consoleColor;
        Console.Write("\n                                                     2)");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" Send File");
        Console.ForegroundColor = consoleColor;
        Console.Write("\n                                                     3)");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" Webhook Spammer");
        Console.ForegroundColor = consoleColor;
        Console.Write("\n                                                     4)");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" Delete Webhook");
        Console.ForegroundColor = consoleColor;
        Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n[>]");
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
                    if (response == "4")
                    {
                        webhookdelete();
                    }
                    else
                    {
                        webhooksender();
                    }
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
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                     Enter Username");
            Console.ForegroundColor = consoleColor;
            Console.Write("\n[>]");
            username = Console.ReadLine();
            log("Webhook: Username set");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                                                      Enter Message");
            Console.ForegroundColor = consoleColor;
            Console.Write("\n[>]");
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
            Console.ForegroundColor = consoleColor;
            Console.Write("Username: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(username);
            Console.ForegroundColor = consoleColor;
            Console.Write(" Message: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message);
            Console.ForegroundColor = consoleColor;
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n                                                     1)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Send");
            Console.ForegroundColor = consoleColor;
            Console.Write("\n                                                     2)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Change info");
            Console.ForegroundColor = consoleColor;
            Console.Write("\n                                                     3)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Quit");
            Console.ForegroundColor = consoleColor;
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n[>]");
            yn = Console.ReadLine();
            if (yn == "1")
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
                catch (Exception ex)
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
                if (yn == "2")
                {
                    webhooksender();
                }
                else
                {
                    Trashtool();
                }
            }




        }

        void filesender()
        {
            string wish;
            string filePath;
            log("Started file sender webhook");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                                                      File location");
            Console.ForegroundColor = consoleColor;
            Console.Write("\n[>]");
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
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = consoleColor;
            Console.Write("File Location: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(filePath);
            Console.ForegroundColor = consoleColor;
            Console.Write(" Send?");
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n                                                     1)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Send");
            Console.ForegroundColor = consoleColor;
            Console.Write("\n                                                     2)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Change info");
            Console.ForegroundColor = consoleColor;
            Console.Write("\n                                                     3)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Quit");
            Console.ForegroundColor = consoleColor;
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n[>]");
            wish = Console.ReadLine();
            if (wish == "1")
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
                catch (Exception ex)
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
                if (wish == "2")
                {
                    filesender();
                    log("Restarted filesender");
                }
                else
                {
                    Trashtool();
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
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                                                      Enter Message");
            Console.ForegroundColor = consoleColor;
            Console.Write("\n[>]");
            message1 = Console.ReadLine();
            if (string.IsNullOrEmpty(message1))
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
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                                                        Enter Delay");
            Console.ForegroundColor = consoleColor;
            Console.Write("\n[>]");
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
            log("Trying to convert string into int");
            if (string.IsNullOrEmpty(delay))
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
            Console.ForegroundColor = consoleColor;
            Console.Write("Message: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message1);
            Console.ForegroundColor = consoleColor;
            Console.Write(" Send?");
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n                                                     1)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Send");
            Console.ForegroundColor = consoleColor;
            Console.Write("\n                                                     2)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Change info");
            Console.ForegroundColor = consoleColor;
            Console.Write("\n                                                     3)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Quit");
            Console.ForegroundColor = consoleColor;
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n[>]");
            ynt = Console.ReadLine();
            if (ynt == "1")
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
                if (ynt == "2")
                {
                    webhooksender();
                    log("Restarted sender");
                }
                else
                {
                    Trashtool();
                    log("Quit.");
                }
            }

        }

        void webhookdelete()
        {
            log("Started webhook deletion");
            string ynt;
            Console.Clear();
            Console.Write("                                                     Are you sure?");
            Console.ForegroundColor = consoleColor;
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n                                                       1)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Yes");
            Console.ForegroundColor = consoleColor;
            Console.Write("\n                                                       2)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" No");
            Console.ForegroundColor = consoleColor;
            Console.ForegroundColor = consoleColor;
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n[>]");
            log("Showed message");
            ynt = Console.ReadLine();
            if (ynt == "1")
            {
                try
                {

                    //Create a new WebRequest with a DELETE method, and get the url (https://docs.microsoft.com/en-us/dotnet/api/system.net.webrequest?view=net-5.0)
                    var request = WebRequest.Create(wurl);
                    request.Method = "DELETE";
                    var response = (HttpWebResponse)request.GetResponse();

                    Console.Write("\n\nWebhook has been deleted!");
                    Thread.Sleep(3000);
                    Trashtool();

                }
                catch (Exception ex)
                {
                    File.AppendAllText("log.log", string.Format("{0}{1}", "------------------------------ERROR------------------------------", Environment.NewLine));
                    File.AppendAllText("log.log", string.Format("{0}{1}", "Error has been catched", Environment.NewLine));
                    File.AppendAllText("log.log", string.Format("{0}{1}", "Message: " + ex.Message, Environment.NewLine));
                    File.AppendAllText("log.log", string.Format("{0}{1}", "Date and Time: " + " [" + DateTime.Now.ToString() + "]", Environment.NewLine));
                    File.AppendAllText("log.log", string.Format("{0}{1}", "------------------------------ERROR------------------------------", Environment.NewLine));
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("\n\nFailed to delete webhook check log for more details.");
                    Thread.Sleep(3000);
                    Trashtool();
                }
            }
            else
            {
                if (ynt == "2")
                {
                    Trashtool();
                    log("Quit.");
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
        string filepath;
        string fn;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("                                                      File location");
        Console.ForegroundColor = consoleColor;
        Console.Write("\n[>]");
        filepath = Console.ReadLine();
        if (string.IsNullOrEmpty(filepath))
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("File path cannot be empty");
            Console.ResetColor();
            Thread.Sleep(3000);
            battoexe();
        }
        log("Batch file provided");
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("                                                    File output name");
        Console.ForegroundColor = consoleColor;
        Console.Write("\n[>]");
        fn = Console.ReadLine();
        if (string.IsNullOrEmpty(fn))
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Name cannot be empty");
            Console.ResetColor();
            Thread.Sleep(3000);
            battoexe();
        }
        log("Name of file provided");
        Console.Clear(); Console.ForegroundColor = ConsoleColor.White; Console.Write("\nGenerating");
        log("File copying.");
        try
        {
            File.Copy(filepath, "bat.bat");
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
        Console.Write("Completed. File is in TrashTool directory");
        Thread.Sleep(3500);
        log("Completed!.");
        Trashtool();


    }

    void maincolor()
    {
        log("Settings: Main Color(needs restart)");
        string color;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n                                                     1) White");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("                                                     2) Green");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("                                                     3) Red");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("                                                     4) Magenta");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("                                                     5) Blue");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("                                                     6) Cyan");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("                                                     7) Dark Yellow");
        Console.ForegroundColor = consoleColor;
        Console.Write("\n\n\n\n\n\n\n\n\n\n\n[>]");
        color = Console.ReadLine();
        if (color == "1")
        {
            log("Settings: SMain Color: Set to White");
            createfile("White");

        }
        else
        if (color == "2")
        {
            log("Settings: Main Color: Set to Green");
            createfile("Green");
        }
        else
        if (color == "3")
        {
            log("Settings: Main Color: Set to DarkRed");
            createfile("DarkRed");
        }
        else
        if (color == "4")
        {
            log("Settings: Main Color: Set to DarkMagenta");
            createfile("DarkMagenta");
        }
        else
        if (color == "5")
        {
            log("Settings: Main Color: Set to DarkBlue");
            createfile("DarkBlue");
        }
        else
        if (color == "6")
        {
            log("Settings: Main Color: Set to DarkCyan");
            createfile("Cyan");
        }
        if (color == "7")
        {
            log("Settings: Main Color: Set to DarkYellow");
            createfile("DarkYellow");
        }
        else
        {
            maincolor();
        }


        void createfile(string color)
        {
            using (FileStream fileStream = File.Create("data\\slc.tt"))
            {
                byte[] bytes = new UTF8Encoding(true).GetBytes(color);
                fileStream.Write(bytes, 0, bytes.Length);
            }
            slc = File.ReadAllText("data\\slc.tt");
            consoleColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), slc, true);
            Trashtool();
        }
    }
}   
catch (Exception ex)
{
    log("Unknown error happened");
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
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Please check logs for more info if you can send log to .hexxadd on discord.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
    log("Quitting applicaton because of an error.");
    System.Environment.Exit(0);




}


void log(string log)
{
    File.AppendAllText("log.log", string.Format("{0}{1}", log + " [" + DateTime.Now.ToString() + "]", Environment.NewLine));
}