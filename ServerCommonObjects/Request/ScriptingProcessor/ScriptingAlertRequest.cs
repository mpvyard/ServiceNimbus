﻿/* 
 * This project is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/
 * Any copyright is dedicated to the NominalNimbus.
 * https://github.com/NominalNimbus 
*/

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServerCommonObjects
{
    [DataContract]
    public class ScriptingAlertRequest : RequestMessage
    {
        [DataMember] public List<string> Alerts { get; set; }
        [DataMember] public ScriptingType Type { get; set; }
        [DataMember] public string CodeId { get; set; }
        [DataMember] public string Login { get; set; }
    }
}