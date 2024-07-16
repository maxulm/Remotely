﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Remotely.Shared.Models;

[DataContract]
public class RemoteControlViewerOptions
{
    [DataMember]
    public bool ShouldRecordSession { get; init; }
}
