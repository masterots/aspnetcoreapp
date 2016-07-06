using System.Runtime.Serialization;
using System.ComponentModel;

namespace WorkoutApi.Enums
{
    public enum WorkoutType
    {
        [EnumMember]
        [Description("Run")]
        Run = 1
    }
}