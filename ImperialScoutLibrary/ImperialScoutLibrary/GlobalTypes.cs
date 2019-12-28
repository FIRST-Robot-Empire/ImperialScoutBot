using System.Runtime.Serialization;

[DataContract]
public enum Regiments
{
    Blue1,
    Blue2,
    Blue3,
    Red1,
    Red2,
    Red3
};

[DataContract]
public enum Campaigns
{
    Practice,
    Qualification,
    Elimination,
    RoundRobin
};

[DataContract]
public enum Alliances
{
    Red,
    Blue
};