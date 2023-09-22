﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderHelper
{
    internal interface IFolderHandler
    {
        string CreateNewFolder(string folderName);

        string CreateNewFolderInTemp(string folderName);
    }
}
