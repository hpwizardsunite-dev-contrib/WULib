// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Requests/Messages/GetFlooNetworkSeasonScoresMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Requests/Messages/GetFlooNetworkSeasonScoresMessage.proto</summary>
  public static partial class GetFlooNetworkSeasonScoresMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Requests/Messages/GetFlooNetworkSeasonScoresMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetFlooNetworkSeasonScoresMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck1XVVByb3Rvcy9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0dldEZs",
            "b29OZXR3b3JrU2Vhc29uU2NvcmVzTWVzc2FnZS5wcm90bxIlV1VQcm90b3Mu",
            "TmV0d29ya2luZy5SZXF1ZXN0cy5NZXNzYWdlcyI2CiFHZXRGbG9vTmV0d29y",
            "a1NlYXNvblNjb3Jlc01lc3NhZ2USEQoJc2Vhc29uX2lkGAEgASgJYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Requests.Messages.GetFlooNetworkSeasonScoresMessage), global::WUProtos.Networking.Requests.Messages.GetFlooNetworkSeasonScoresMessage.Parser, new[]{ "SeasonId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetFlooNetworkSeasonScoresMessage : pb::IMessage<GetFlooNetworkSeasonScoresMessage> {
    private static readonly pb::MessageParser<GetFlooNetworkSeasonScoresMessage> _parser = new pb::MessageParser<GetFlooNetworkSeasonScoresMessage>(() => new GetFlooNetworkSeasonScoresMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetFlooNetworkSeasonScoresMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Requests.Messages.GetFlooNetworkSeasonScoresMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetFlooNetworkSeasonScoresMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetFlooNetworkSeasonScoresMessage(GetFlooNetworkSeasonScoresMessage other) : this() {
      seasonId_ = other.seasonId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetFlooNetworkSeasonScoresMessage Clone() {
      return new GetFlooNetworkSeasonScoresMessage(this);
    }

    /// <summary>Field number for the "season_id" field.</summary>
    public const int SeasonIdFieldNumber = 1;
    private string seasonId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SeasonId {
      get { return seasonId_; }
      set {
        seasonId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetFlooNetworkSeasonScoresMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetFlooNetworkSeasonScoresMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SeasonId != other.SeasonId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SeasonId.Length != 0) hash ^= SeasonId.GetHashCode();
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
      if (SeasonId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SeasonId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SeasonId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SeasonId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetFlooNetworkSeasonScoresMessage other) {
      if (other == null) {
        return;
      }
      if (other.SeasonId.Length != 0) {
        SeasonId = other.SeasonId;
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
            SeasonId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code