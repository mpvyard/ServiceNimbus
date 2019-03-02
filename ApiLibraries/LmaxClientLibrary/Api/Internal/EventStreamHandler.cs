﻿/* 
 * This project is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/
 * Any copyright is dedicated to the NominalNimbus.
 * https://github.com/NominalNimbus 
*/

using System.IO;

namespace Com.Lmax.Api.Internal
{
    public class EventStreamHandler
    {
        private readonly ISaxContentHandler _saxContentHandler;

        // for testing only
        public EventStreamHandler() : this(null)
        {
        }

        public EventStreamHandler(ISaxContentHandler saxContentHandler)
        {
            _saxContentHandler = saxContentHandler;
        }

        public virtual void ParseEventStream(TextReader reader)
        {
            new SaxParser().Parse(reader, _saxContentHandler);
        }
    }
}
