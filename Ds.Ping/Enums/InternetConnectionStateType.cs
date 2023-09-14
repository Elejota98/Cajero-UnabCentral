﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ds.Ping
{
    [Flags]
    public enum InternetConnectionStatesType : int
    {
        ModemConnection = 0x1,
        LANConnection = 0x2,
        ProxyConnection = 0x4,
        RASInstalled = 0x10,
        Offline = 0x20,
        ConnectionConfigured = 0x40
    }
}
