﻿using MessengerServer.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerServer.DataAccessLayer.Interfaces
{
    public interface IDialogMessageRepository : IRepository<DialogMessage>
    {
        string GetTextOfDialogMessage(int DialogMessageId);
    }
}
