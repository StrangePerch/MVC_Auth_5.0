﻿public class SmtpServer
{
    public string Host { get; set; }
    public string Port { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
}

public class EmailOptions
{
    public string Receiver { get; set; }
    public string Subject { get; set; }
    public SmtpServer SmtpServer { get; set; }
}