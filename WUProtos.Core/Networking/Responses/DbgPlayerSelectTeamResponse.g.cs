// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/DbgPlayerSelectTeamResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/DbgPlayerSelectTeamResponse.proto</summary>
  public static partial class DbgPlayerSelectTeamResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/DbgPlayerSelectTeamResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DbgPlayerSelectTeamResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9XVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9EYmdQbGF5ZXJTZWxl",
            "Y3RUZWFtUmVzcG9uc2UucHJvdG8SHVdVUHJvdG9zLk5ldHdvcmtpbmcuUmVz",
            "cG9uc2VzIqoBChtEYmdQbGF5ZXJTZWxlY3RUZWFtUmVzcG9uc2USUQoGcmVz",
            "dWx0GAEgASgOMkEuV1VQcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuRGJn",
            "UGxheWVyU2VsZWN0VGVhbVJlc3BvbnNlLlJlc3VsdCI4CgZSZXN1bHQSCwoH",
            "VU5LTk9XThAAEgwKCFRFQU1fU0VUEAESEwoPVEVBTV9JRF9JTlZBTElEEAJi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.DbgPlayerSelectTeamResponse), global::WUProtos.Networking.Responses.DbgPlayerSelectTeamResponse.Parser, new[]{ "Result" }, null, new[]{ typeof(global::WUProtos.Networking.Responses.DbgPlayerSelectTeamResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DbgPlayerSelectTeamResponse : pb::IMessage<DbgPlayerSelectTeamResponse> {
    private static readonly pb::MessageParser<DbgPlayerSelectTeamResponse> _parser = new pb::MessageParser<DbgPlayerSelectTeamResponse>(() => new DbgPlayerSelectTeamResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DbgPlayerSelectTeamResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.DbgPlayerSelectTeamResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgPlayerSelectTeamResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgPlayerSelectTeamResponse(DbgPlayerSelectTeamResponse other) : this() {
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DbgPlayerSelectTeamResponse Clone() {
      return new DbgPlayerSelectTeamResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::WUProtos.Networking.Responses.DbgPlayerSelectTeamResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Responses.DbgPlayerSelectTeamResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DbgPlayerSelectTeamResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DbgPlayerSelectTeamResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
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
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DbgPlayerSelectTeamResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
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
          case 8: {
            Result = (global::WUProtos.Networking.Responses.DbgPlayerSelectTeamResponse.Types.Result) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the DbgPlayerSelectTeamResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("TEAM_SET")] TeamSet = 1,
        [pbr::OriginalName("TEAM_ID_INVALID")] TeamIdInvalid = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
