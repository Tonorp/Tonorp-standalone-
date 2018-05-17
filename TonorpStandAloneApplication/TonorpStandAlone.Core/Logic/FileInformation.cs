using System;
using System.IO;

namespace TonorpStandAlone.Core.Logic
{
    /// <summary>
    /// Handles Reading and Writing of File to the specified path
    /// </summary>
    public class FileInformation
    {
        /// <summary>
        /// The base folder in the User's Computer where this project is saved
        /// </summary>
        private static readonly string BasePath = new DirectoryInfo(".").ToString();

        /// <summary>
        /// Creates and returns Logged-in User's base file path
        /// </summary>
        /// <returns></returns>
        public static string GetBaseFilePath()
        {
            var filePath = BasePath + @"\LoggedInUser";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            return filePath;
        }

        /// <summary>
        /// Creates and returns Logged-in user's directory
        /// </summary>
        /// <returns></returns>
        public static string GetLoggedInUserFileDirectory()
        {
            var dirPath = BasePath + @"\Users\" + LoggedInUser.GetLoggedInUser()?.RegNo;

            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            return dirPath;
        }

        /// <summary>
        /// Reads and returns all text in specified path
        /// </summary>
        /// <param name="path">The Path to write file</param>
        /// <param name="errMsg">Output Variable to hold Error Message in case writing fails</param>
        /// <returns></returns>
        public string ReadFileToEnd(string path, out string errMsg)
        {
            try
            {
                if (!File.Exists(path))
                {
                    errMsg = "The specified file path could not be found!";
                    return null;
                }
                var readFile = File.ReadAllText(path);
                errMsg = string.Empty;
                return readFile;
            }
            catch (Exception e)
            {
                errMsg = e.Message;
                return null;
            }

        }

        /// <summary>
        /// Write supplied text to the specified path
        /// </summary>
        /// <param name="path">The Path to write file</param>
        /// <param name="fileToWrite">The File to write</param>
        /// <param name="errMsg">Output Variable to hold Error Message in case writing fails</param>
        /// <returns></returns>
        public bool WriteFile(string path, string fileToWrite, out string errMsg)
        {
            try
            {
                File.WriteAllText(path, fileToWrite);
                errMsg = string.Empty;
                return true;
            }
            catch (Exception e)
            {
                errMsg = e.Message;
                return false;
            }
        }

        /// <summary>
        /// Create directory if it does not already exist
        /// </summary>
        /// <param name="path">The Directory to create</param>
        public void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }
    }
}
