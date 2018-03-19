namespace Plisky.FlimFlam {

    using System;

    /// <summary>
    /// Message type, each message that is placed into the input queue is categorized by its type.  This is only possible when supporting clients which
    /// send specially formatted messages, everyone else just gets a standard message type.
    /// </summary>
    [Flags]
    public enum MessageType : uint {
        InfoMessage = 0x00000001,
        VerboseMessage = 0x00000002,

        // Mini removed, new one can go here @ 0x04
        InternalMsg = 0x00000008,

        TraceMessageIn = 0x00000010,
        TraceMessageOut = 0x00000020,

        // TraceMessage removed, new one can go here at = 0x00000040,
        AssertionFailed = 0x00000080,

        MoreInfo = 0x00000100,
        CommandOnly = 0x00000200,
        ErrorMsg = 0x00000400,
        WarningMsg = 0x00000800,
        ExceptionBlock = 0x00001000,
        ExceptionData = 0x00002000,
        ExceptionBlockStart = 0x00004000,
        ExceptionBlockEnd = 0x00008000,
        SectionStart = 0x00010000,
        SectionEnd = 0x00020000,
        ResourceEat = 0x00040000,
        ResourcePuke = 0x00080000,
        ResourceCount = 0x00100000,
        Standard = 0x00200000,
        Unknown = 0x00000000,
        CommandXML = 0x400000
    }
}