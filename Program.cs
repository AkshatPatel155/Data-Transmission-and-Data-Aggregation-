using ConsoleApp3.Models;


string host = "ftp://waws-prod-yt1-039.ftp.azurewebsites.windows.net//22S_BDAT1001/Section_2/BDAT1001_30632";
string name = "ftpservernital\bdat1001-user";
string password = "Bdat1001#";

DirectoryList obj = new DirectoryList();
obj.GetDirectoryList(host,name,password);