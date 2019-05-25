// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/AddLoginResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/AddLoginResponse.proto</summary>
  public static partial class AddLoginResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/AddLoginResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AddLoginResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9BZGRMb2dpblJlc3Bv",
            "bnNlLnByb3RvEh1XVVByb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcxofV1VQ",
            "cm90b3MvRGF0YS9Mb2dpbkRldGFpbC5wcm90byLVAQoQQWRkTG9naW5SZXNw",
            "b25zZRIPCgdzdWNjZXNzGAEgASgIEjAKDGxvZ2luX2RldGFpbBgCIAMoCzIa",
            "LldVUHJvdG9zLkRhdGEuTG9naW5EZXRhaWwSRgoGc3RhdHVzGAMgASgOMjYu",
            "V1VQcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuQWRkTG9naW5SZXNwb25z",
            "ZS5TdGF0dXMiNgoGU3RhdHVzEgkKBVVOU0VUEAASEAoMQVVUSF9GQUlMVVJF",
            "EAESDwoLTE9HSU5fVEFLRU4QAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.LoginDetailReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.AddLoginResponse), global::WUProtos.Networking.Responses.AddLoginResponse.Parser, new[]{ "Success", "LoginDetail", "Status" }, null, new[]{ typeof(global::WUProtos.Networking.Responses.AddLoginResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AddLoginResponse : pb::IMessage<AddLoginResponse> {
    private static readonly pb::MessageParser<AddLoginResponse> _parser = new pb::MessageParser<AddLoginResponse>(() => new AddLoginResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddLoginResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.AddLoginResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddLoginResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddLoginResponse(AddLoginResponse other) : this() {
      success_ = other.success_;
      loginDetail_ = other.loginDetail_.Clone();
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddLoginResponse Clone() {
      return new AddLoginResponse(this);
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    /// <summary>Field number for the "login_detail" field.</summary>
    public const int LoginDetailFieldNumber = 2;
    private static readonly pb::FieldCodec<global::WUProtos.Data.LoginDetail> _repeated_loginDetail_codec
        = pb::FieldCodec.ForMessage(18, global::WUProtos.Data.LoginDetail.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Data.LoginDetail> loginDetail_ = new pbc::RepeatedField<global::WUProtos.Data.LoginDetail>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Data.LoginDetail> LoginDetail {
      get { return loginDetail_; }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 3;
    private global::WUProtos.Networking.Responses.AddLoginResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Responses.AddLoginResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddLoginResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddLoginResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      if(!loginDetail_.Equals(other.loginDetail_)) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Success != false) hash ^= Success.GetHashCode();
      hash ^= loginDetail_.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
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
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      loginDetail_.WriteTo(output, _repeated_loginDetail_codec);
      if (Status != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      size += loginDetail_.CalculateSize(_repeated_loginDetail_codec);
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddLoginResponse other) {
      if (other == null) {
        return;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      loginDetail_.Add(other.loginDetail_);
      if (other.Status != 0) {
        Status = other.Status;
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
            Success = input.ReadBool();
            break;
          }
          case 18: {
            loginDetail_.AddEntriesFrom(input, _repeated_loginDetail_codec);
            break;
          }
          case 24: {
            Status = (global::WUProtos.Networking.Responses.AddLoginResponse.Types.Status) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the AddLoginResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("AUTH_FAILURE")] AuthFailure = 1,
        [pbr::OriginalName("LOGIN_TAKEN")] LoginTaken = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
