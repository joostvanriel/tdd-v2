using System;
using System.Collections.Generic;
using System.IO;

namespace SproutMethod
{
    public class FileUpdateManager
    {
        public void AppendFilesWithText(IList<string> filePaths, string textToAppend)
        {
            foreach (var file in filePaths)
            {
                if (File.Exists(file) && string.IsNullOrEmpty(textToAppend))
                {
                    File.AppendAllText(file, textToAppend);
                }
            }

            // TODO: This method needs to be extended so that a list of recipients is mailed with the changed filepaths.
        }
    }
}
