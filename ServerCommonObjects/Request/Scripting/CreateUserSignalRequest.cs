﻿/* 
 * This project is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/
 * Any copyright is dedicated to the NominalNimbus.
 * https://github.com/NominalNimbus 
*/

using System.Collections.Generic;
using System.Runtime.Serialization;
using CommonObjects;

namespace ServerCommonObjects
{
    [DataContract]
    public class CreateUserSignalRequest : RequestMessage
    {
        [DataMember]
        public string SignalName { get; set; }

        [DataMember]
        public StrategyParams StrategyParameters { get; set; }

        [DataMember]
        public List<ScriptingParameterBase> Parameters { get; set; }

        [DataMember]
        public List<Selection> Selections { get; set; }

        [DataMember]
        public BacktestSettings BacktestSettings { get; set; }

        [DataMember]
        public SignalState InitialState { get; set; }

        [DataMember]
        public Dictionary<string, byte[]> Files { get; set; }

        [DataMember]
        public List<PortfolioAccount> AccountInfos { get; set; }
    }
}