// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/CheckWalkboxesResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/CheckWalkboxesResponse.proto</summary>
  public static partial class CheckWalkboxesResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/CheckWalkboxesResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CheckWalkboxesResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjpXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9DaGVja1dhbGtib3hl",
            "c1Jlc3BvbnNlLnByb3RvEh1XVVByb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNl",
            "cxojV1VQcm90b3MvRGF0YS9Mb290L0xvb3RSZXdhcmQucHJvdG8ihgIKFkNo",
            "ZWNrV2Fsa2JveGVzUmVzcG9uc2USYgoQb3BlbmVkX3dhbGtib3hlcxgBIAMo",
            "CzJILldVUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLkNoZWNrV2Fsa2Jv",
            "eGVzUmVzcG9uc2UuT3BlbmVkV2Fsa2JveFByb3RvGocBChJPcGVuZWRXYWxr",
            "Ym94UHJvdG8SHAoUd2Fsa2JveF9nbXRfdGVtcGxhdGUYASABKAkSPgoHcmV3",
            "YXJkcxgCIAEoCzItLldVUHJvdG9zLkRhdGEuTG9vdC5Mb290UmV3YXJkLkxv",
            "b3RDb2xsZWN0aW9uEhMKC3BvcnRrZXlfaWRzGAMgAygDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Loot.LootRewardReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.CheckWalkboxesResponse), global::WUProtos.Networking.Responses.CheckWalkboxesResponse.Parser, new[]{ "OpenedWalkboxes" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.CheckWalkboxesResponse.Types.OpenedWalkboxProto), global::WUProtos.Networking.Responses.CheckWalkboxesResponse.Types.OpenedWalkboxProto.Parser, new[]{ "WalkboxGmtTemplate", "Rewards", "PortkeyIds" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CheckWalkboxesResponse : pb::IMessage<CheckWalkboxesResponse> {
    private static readonly pb::MessageParser<CheckWalkboxesResponse> _parser = new pb::MessageParser<CheckWalkboxesResponse>(() => new CheckWalkboxesResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CheckWalkboxesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.CheckWalkboxesResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckWalkboxesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckWalkboxesResponse(CheckWalkboxesResponse other) : this() {
      openedWalkboxes_ = other.openedWalkboxes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckWalkboxesResponse Clone() {
      return new CheckWalkboxesResponse(this);
    }

    /// <summary>Field number for the "opened_walkboxes" field.</summary>
    public const int OpenedWalkboxesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::WUProtos.Networking.Responses.CheckWalkboxesResponse.Types.OpenedWalkboxProto> _repeated_openedWalkboxes_codec
        = pb::FieldCodec.ForMessage(10, global::WUProtos.Networking.Responses.CheckWalkboxesResponse.Types.OpenedWalkboxProto.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Networking.Responses.CheckWalkboxesResponse.Types.OpenedWalkboxProto> openedWalkboxes_ = new pbc::RepeatedField<global::WUProtos.Networking.Responses.CheckWalkboxesResponse.Types.OpenedWalkboxProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Networking.Responses.CheckWalkboxesResponse.Types.OpenedWalkboxProto> OpenedWalkboxes {
      get { return openedWalkboxes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CheckWalkboxesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CheckWalkboxesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!openedWalkboxes_.Equals(other.openedWalkboxes_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= openedWalkboxes_.GetHashCode();
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
      openedWalkboxes_.WriteTo(output, _repeated_openedWalkboxes_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += openedWalkboxes_.CalculateSize(_repeated_openedWalkboxes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CheckWalkboxesResponse other) {
      if (other == null) {
        return;
      }
      openedWalkboxes_.Add(other.openedWalkboxes_);
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
            openedWalkboxes_.AddEntriesFrom(input, _repeated_openedWalkboxes_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CheckWalkboxesResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class OpenedWalkboxProto : pb::IMessage<OpenedWalkboxProto> {
        private static readonly pb::MessageParser<OpenedWalkboxProto> _parser = new pb::MessageParser<OpenedWalkboxProto>(() => new OpenedWalkboxProto());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<OpenedWalkboxProto> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::WUProtos.Networking.Responses.CheckWalkboxesResponse.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public OpenedWalkboxProto() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public OpenedWalkboxProto(OpenedWalkboxProto other) : this() {
          walkboxGmtTemplate_ = other.walkboxGmtTemplate_;
          rewards_ = other.rewards_ != null ? other.rewards_.Clone() : null;
          portkeyIds_ = other.portkeyIds_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public OpenedWalkboxProto Clone() {
          return new OpenedWalkboxProto(this);
        }

        /// <summary>Field number for the "walkbox_gmt_template" field.</summary>
        public const int WalkboxGmtTemplateFieldNumber = 1;
        private string walkboxGmtTemplate_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string WalkboxGmtTemplate {
          get { return walkboxGmtTemplate_; }
          set {
            walkboxGmtTemplate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "rewards" field.</summary>
        public const int RewardsFieldNumber = 2;
        private global::WUProtos.Data.Loot.LootReward.Types.LootCollection rewards_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::WUProtos.Data.Loot.LootReward.Types.LootCollection Rewards {
          get { return rewards_; }
          set {
            rewards_ = value;
          }
        }

        /// <summary>Field number for the "portkey_ids" field.</summary>
        public const int PortkeyIdsFieldNumber = 3;
        private static readonly pb::FieldCodec<long> _repeated_portkeyIds_codec
            = pb::FieldCodec.ForInt64(26);
        private readonly pbc::RepeatedField<long> portkeyIds_ = new pbc::RepeatedField<long>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<long> PortkeyIds {
          get { return portkeyIds_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as OpenedWalkboxProto);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(OpenedWalkboxProto other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (WalkboxGmtTemplate != other.WalkboxGmtTemplate) return false;
          if (!object.Equals(Rewards, other.Rewards)) return false;
          if(!portkeyIds_.Equals(other.portkeyIds_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (WalkboxGmtTemplate.Length != 0) hash ^= WalkboxGmtTemplate.GetHashCode();
          if (rewards_ != null) hash ^= Rewards.GetHashCode();
          hash ^= portkeyIds_.GetHashCode();
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
          if (WalkboxGmtTemplate.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(WalkboxGmtTemplate);
          }
          if (rewards_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(Rewards);
          }
          portkeyIds_.WriteTo(output, _repeated_portkeyIds_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (WalkboxGmtTemplate.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(WalkboxGmtTemplate);
          }
          if (rewards_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rewards);
          }
          size += portkeyIds_.CalculateSize(_repeated_portkeyIds_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(OpenedWalkboxProto other) {
          if (other == null) {
            return;
          }
          if (other.WalkboxGmtTemplate.Length != 0) {
            WalkboxGmtTemplate = other.WalkboxGmtTemplate;
          }
          if (other.rewards_ != null) {
            if (rewards_ == null) {
              Rewards = new global::WUProtos.Data.Loot.LootReward.Types.LootCollection();
            }
            Rewards.MergeFrom(other.Rewards);
          }
          portkeyIds_.Add(other.portkeyIds_);
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
                WalkboxGmtTemplate = input.ReadString();
                break;
              }
              case 18: {
                if (rewards_ == null) {
                  Rewards = new global::WUProtos.Data.Loot.LootReward.Types.LootCollection();
                }
                input.ReadMessage(Rewards);
                break;
              }
              case 26:
              case 24: {
                portkeyIds_.AddEntriesFrom(input, _repeated_portkeyIds_codec);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
