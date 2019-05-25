// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/ProfessionSelectMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/ProfessionSelectMessage.proto</summary>
  public static partial class ProfessionSelectMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/ProfessionSelectMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProfessionSelectMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNXVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL1Byb2Zl",
            "c3Npb25TZWxlY3RNZXNzYWdlLnByb3RvEiVXVVByb3Rvcy5OZXR3b3JraW5n",
            "LlJlcXVlc3RzLk1lc3NhZ2VzIjQKF1Byb2Zlc3Npb25TZWxlY3RNZXNzYWdl",
            "EhkKEXByb2Zlc3Npb25fZ210X2lkGAEgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.ProfessionSelectMessage), global::WUProtos.Networking.Requests.Messages.ProfessionSelectMessage.Parser, new[]{ "ProfessionGmtId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProfessionSelectMessage : pb::IMessage<ProfessionSelectMessage> {
    private static readonly pb::MessageParser<ProfessionSelectMessage> _parser = new pb::MessageParser<ProfessionSelectMessage>(() => new ProfessionSelectMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProfessionSelectMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.ProfessionSelectMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionSelectMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionSelectMessage(ProfessionSelectMessage other) : this() {
      professionGmtId_ = other.professionGmtId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProfessionSelectMessage Clone() {
      return new ProfessionSelectMessage(this);
    }

    /// <summary>Field number for the "profession_gmt_id" field.</summary>
    public const int ProfessionGmtIdFieldNumber = 1;
    private string professionGmtId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProfessionGmtId {
      get { return professionGmtId_; }
      set {
        professionGmtId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProfessionSelectMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProfessionSelectMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProfessionGmtId != other.ProfessionGmtId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ProfessionGmtId.Length != 0) hash ^= ProfessionGmtId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ProfessionGmtId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProfessionGmtId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ProfessionGmtId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProfessionGmtId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProfessionSelectMessage other) {
      if (other == null) {
        return;
      }
      if (other.ProfessionGmtId.Length != 0) {
        ProfessionGmtId = other.ProfessionGmtId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ProfessionGmtId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
