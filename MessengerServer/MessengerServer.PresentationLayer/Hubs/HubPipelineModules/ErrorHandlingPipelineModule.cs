﻿//using Microsoft.AspNet.SignalR.Hubs;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MessengerServer.Hubs.HubPipelineModules
//{
//    public class ErrorHandlingPipelineModule : HubPipelineModule
//    {
//        protected override void OnIncomingError(ExceptionContext exceptionContext, IHubIncomingInvokerContext invokerContext)
//        {
//            Debug.WriteLine("=> Exception " + exceptionContext.Error.Message);
//            if (exceptionContext.Error.InnerException != null)
//            {
//                Debug.WriteLine("=> Inner Exception " + exceptionContext.Error.InnerException.Message);
//            }
//            base.OnIncomingError(exceptionContext, invokerContext);
//        }
//    }
//}
