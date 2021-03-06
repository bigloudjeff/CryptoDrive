﻿using System;

namespace CryptoDrive.Core
{
    public class RemoteState
    {
        #region Properties

        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string QuickXorHash { get; set; }
        public long Size { get; set; }
        public DriveItemType Type { get; set; }
        public DateTime LastModified { get; set; }
        public bool IsLocal { get; set; }

        #endregion

        #region Methods

        public string GetItemPath()
        {
            return PathHelper.Combine(this.Path, this.Name);
        }

        #endregion
    }
}
