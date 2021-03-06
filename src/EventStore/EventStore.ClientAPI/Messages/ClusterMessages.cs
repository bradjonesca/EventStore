﻿// Copyright (c) 2012, Event Store LLP
// All rights reserved.
//  
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
//  
// Redistributions of source code must retain the above copyright notice,
// this list of conditions and the following disclaimer.
// Redistributions in binary form must reproduce the above copyright
// notice, this list of conditions and the following disclaimer in the
// documentation and/or other materials provided with the distribution.
// Neither the name of the Event Store LLP nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;

namespace EventStore.ClientAPI.Messages
{
    public class ClusterMessages
    {
        public class ClusterInfoDto
        {
            public MemberInfoDto[] Members { get; set; }

            public ClusterInfoDto()
            {
            }

            public ClusterInfoDto(MemberInfoDto[] members)
            {
                Members = members;
            }
        }

        public class MemberInfoDto
        {
            public DateTime TimeStamp { get; set; }
            public VNodeState State { get; set; }
            public bool IsAlive { get; set; }

            public string InternalTcpIp { get; set; }
            public int InternalTcpPort { get; set; }

            public string ExternalTcpIp { get; set; }
            public int ExternalTcpPort { get; set; }

            public string InternalHttpIp { get; set; }
            public int InternalHttpPort { get; set; }

            public string ExternalHttpIp { get; set; }
            public int ExternalHttpPort { get; set; }

            public long WriterCheckpoint { get; set; }
            public long ChaserCheckpoint { get; set; }
        }

        public enum VNodeState
        {
            Initializing,
            Unknown,
            CatchingUp,
            Clone,
            Slave,
            Master,
            Manager,
            ShuttingDown,
            Shutdown
        }
    }
}
