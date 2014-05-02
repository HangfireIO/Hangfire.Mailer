using System;
using Common.Logging;
using HangFire.Common;
using HangFire.States;
using HangFire.Storage;

namespace HangFire.Mailer.Controllers
{
    public class LogFailureAttribute : JobFilterAttribute, IApplyStateFilter
    {
        private static readonly ILog Logger = LogManager.GetCurrentClassLogger();

        public void OnStateApplied(ApplyStateContext context, IWriteOnlyTransaction transaction)
        {
            var failedState = context.NewState as FailedState;
            if (failedState != null)
            {
                Logger.Error(
                    String.Format("Background job #{0} was failed with an exception.", context.JobId), 
                    failedState.Exception);
            }
        }

        public void OnStateUnapplied(ApplyStateContext context, IWriteOnlyTransaction transaction)
        {
        }
    }
}