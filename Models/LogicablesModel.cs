
using System.Collections.Generic;
using Assets.Scripts;
using Assets.Scripts.Objects.Pipes;
using WebAPI.Payloads;

namespace WebAPI.Models
{
    public static class LogicablesModel
    {
        public static IDictionary<string, LogicValuePayload> GetLogicStates(long referenceId)
        {
            var logicable = OcclusionManager.AllThings.Find(x => x.ReferenceId == referenceId) as ILogicable;
            if (logicable == null)
            {
                return null;
            }

            return LogicableItemUtils.GetLogicValues(logicable);
        }
    }
}