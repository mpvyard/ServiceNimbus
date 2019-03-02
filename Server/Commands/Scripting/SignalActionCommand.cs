﻿/* 
This project is subject to the terms of the Mozilla Public
License, v. 2.0. If a copy of the MPL was not distributed with this
file, You can obtain one at http://mozilla.org/MPL/2.0/
Any copyright is dedicated to the NominalNimbus.
https://github.com/NominalNimbus 
*/

using System.Threading.Tasks;
using ServerCommonObjects;
using Server.Interfaces;

namespace Server.Commands.Scripting
{
    internal sealed class SignalActionCommand : CommandBase<SignalActionRequest>
    {
        #region Constructors

        public SignalActionCommand(ICore core, IPusher pusher) : base(core, pusher)
        {
        }

        #endregion // Constructors

        #region CommandBase

        protected override void ExecuteCommand(SignalActionRequest request)
        {
            var serviceID = Core.GetScriptingServiceID(request.User.Login, request.SignalName, ScriptingType.Signal);
            var service = Core.GetProcessor(serviceID);
            if (service == null) return;

            Task.Run(() =>
            {
                PushToProcessor(new SetSignalActionResponse
                {
                    Username = request.User.Login,
                    Action = request.Action,
                    SignalName = request.SignalName
                }, service);
            });
        }

        #endregion // CommandBase
    }
}
