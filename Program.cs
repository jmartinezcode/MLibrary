
using NLog;


string path = Directory.GetCurrentDirectory() + "\\nlog.config";

// create instance of Logger
var logger = LogManager.LoadConfiguration(path).GetCurrentClassLogger();
string movieFilePath = Directory.GetCurrentDirectory() + "\\movies.csv"; 

logger.Info("Program started");

MovieFile movieFile = new MovieFile(movieFilePath);

logger.Info("Program ended");
