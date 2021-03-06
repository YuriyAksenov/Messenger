﻿using MessengerServer.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerServer.DataAccessLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IContactRepository Contacts { get; }
        IListRepository Lists { get; }
        IListContactRepository ListContacts { get; }
        IDialogRepository Dialogs { get; }
        IDialogMessageRepository DialogMessages { get;}
        void Save();
    }
}
