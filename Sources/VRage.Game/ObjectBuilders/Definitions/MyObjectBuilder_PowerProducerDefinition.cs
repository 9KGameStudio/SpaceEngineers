﻿using ProtoBuf;
using VRage.ObjectBuilders;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_PowerProducerDefinition : MyObjectBuilder_CubeBlockDefinition
    {
        [ProtoMember]
        public float MaxPowerOutput;
    }
}
