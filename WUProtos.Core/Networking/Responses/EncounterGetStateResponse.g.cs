// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/EncounterGetStateResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/EncounterGetStateResponse.proto</summary>
  public static partial class EncounterGetStateResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/EncounterGetStateResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EncounterGetStateResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1XVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9FbmNvdW50ZXJHZXRT",
            "dGF0ZVJlc3BvbnNlLnByb3RvEh1XVVByb3Rvcy5OZXR3b3JraW5nLlJlc3Bv",
            "bnNlcxooV1VQcm90b3MvRGF0YS9Db21iYXQvQ29tYmF0UmVzdWx0cy5wcm90",
            "byLQBwoZRW5jb3VudGVyR2V0U3RhdGVSZXNwb25zZRJPCgZzdGF0dXMYASAB",
            "KA4yPy5XVVByb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5FbmNvdW50ZXJH",
            "ZXRTdGF0ZVJlc3BvbnNlLlN0YXR1cxIbChNjdXJyZW50X3N0YWdlX2luZGV4",
            "GAIgASgFEmQKBXN0YWdlGAMgASgLMlUuV1VQcm90b3MuTmV0d29ya2luZy5S",
            "ZXNwb25zZXMuRW5jb3VudGVyR2V0U3RhdGVSZXNwb25zZS5FbmNvdW50ZXJH",
            "ZXRTdGF0ZVN0YWdlUmVzdWx0Gr8DChxFbmNvdW50ZXJHZXRTdGF0ZVN0YWdl",
            "UmVzdWx0EogBCgVzd2lzaBgBIAEoCzJ3LldVUHJvdG9zLk5ldHdvcmtpbmcu",
            "UmVzcG9uc2VzLkVuY291bnRlckdldFN0YXRlUmVzcG9uc2UuRW5jb3VudGVy",
            "R2V0U3RhdGVTdGFnZVJlc3VsdC5FbmNvdW50ZXJHZXRTdGF0ZVN3aXNoU3Rh",
            "Z2VSZXN1bHRIABKKAQoGY29tYmF0GAIgASgLMnguV1VQcm90b3MuTmV0d29y",
            "a2luZy5SZXNwb25zZXMuRW5jb3VudGVyR2V0U3RhdGVSZXNwb25zZS5FbmNv",
            "dW50ZXJHZXRTdGF0ZVN0YWdlUmVzdWx0LkVuY291bnRlckdldFN0YXRlQ29t",
            "YmF0U3RhZ2VSZXN1bHRIABojCiFFbmNvdW50ZXJHZXRTdGF0ZVN3aXNoU3Rh",
            "Z2VSZXN1bHQaWgoiRW5jb3VudGVyR2V0U3RhdGVDb21iYXRTdGFnZVJlc3Vs",
            "dBI0CgdyZXN1bHRzGAEgASgLMiMuV1VQcm90b3MuRGF0YS5Db21iYXQuQ29t",
            "YmF0UmVzdWx0c0IGCgRUeXBlIpwCCgZTdGF0dXMSHwobRU5DT1VOVEVSX0dF",
            "VF9TVEFURV9VTktOT1dOEAASHwobRU5DT1VOVEVSX0dFVF9TVEFURV9TVUND",
            "RVNTEAESKAokRU5DT1VOVEVSX0dFVF9TVEFURV9OT1RfSU5fRU5DT1VOVEVS",
            "EAISKQolRU5DT1VOVEVSX0dFVF9TVEFURV9DTElFTlRfU1RBTEVfREFUQRAD",
            "Eh0KGUVOQ09VTlRFUl9HRVRfU1RBVEVfRVJST1IQBBIwCixFTkNPVU5URVJf",
            "R0VUX1NUQVRFX1dDX1BMQVlFUl9OT1RfSU5fQ0hBTUJFUhAFEioKJkVOQ09V",
            "TlRFUl9HRVRfU1RBVEVfV0NfTk9UX0lOX1BST0dSRVNTEAZiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::WUProtos.Data.Combat.CombatResultsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.EncounterGetStateResponse), global::WUProtos.Networking.Responses.EncounterGetStateResponse.Parser, new[]{ "Status", "CurrentStageIndex", "Stage" }, null, new[]{ typeof(global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.Status) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult), global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Parser, new[]{ "Swish", "Combat" }, new[]{ "Type" }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Types.EncounterGetStateSwishStageResult), global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Types.EncounterGetStateSwishStageResult.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Types.EncounterGetStateCombatStageResult), global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Types.EncounterGetStateCombatStageResult.Parser, new[]{ "Results" }, null, null, null)})})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EncounterGetStateResponse : pb::IMessage<EncounterGetStateResponse> {
    private static readonly pb::MessageParser<EncounterGetStateResponse> _parser = new pb::MessageParser<EncounterGetStateResponse>(() => new EncounterGetStateResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EncounterGetStateResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.EncounterGetStateResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterGetStateResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterGetStateResponse(EncounterGetStateResponse other) : this() {
      status_ = other.status_;
      currentStageIndex_ = other.currentStageIndex_;
      stage_ = other.stage_ != null ? other.stage_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EncounterGetStateResponse Clone() {
      return new EncounterGetStateResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "current_stage_index" field.</summary>
    public const int CurrentStageIndexFieldNumber = 2;
    private int currentStageIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CurrentStageIndex {
      get { return currentStageIndex_; }
      set {
        currentStageIndex_ = value;
      }
    }

    /// <summary>Field number for the "stage" field.</summary>
    public const int StageFieldNumber = 3;
    private global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult stage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult Stage {
      get { return stage_; }
      set {
        stage_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EncounterGetStateResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EncounterGetStateResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (CurrentStageIndex != other.CurrentStageIndex) return false;
      if (!object.Equals(Stage, other.Stage)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (CurrentStageIndex != 0) hash ^= CurrentStageIndex.GetHashCode();
      if (stage_ != null) hash ^= Stage.GetHashCode();
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
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (CurrentStageIndex != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(CurrentStageIndex);
      }
      if (stage_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Stage);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (CurrentStageIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CurrentStageIndex);
      }
      if (stage_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Stage);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EncounterGetStateResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.CurrentStageIndex != 0) {
        CurrentStageIndex = other.CurrentStageIndex;
      }
      if (other.stage_ != null) {
        if (stage_ == null) {
          Stage = new global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult();
        }
        Stage.MergeFrom(other.Stage);
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
            Status = (global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 16: {
            CurrentStageIndex = input.ReadInt32();
            break;
          }
          case 26: {
            if (stage_ == null) {
              Stage = new global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult();
            }
            input.ReadMessage(Stage);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the EncounterGetStateResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("ENCOUNTER_GET_STATE_UNKNOWN")] EncounterGetStateUnknown = 0,
        [pbr::OriginalName("ENCOUNTER_GET_STATE_SUCCESS")] EncounterGetStateSuccess = 1,
        [pbr::OriginalName("ENCOUNTER_GET_STATE_NOT_IN_ENCOUNTER")] EncounterGetStateNotInEncounter = 2,
        [pbr::OriginalName("ENCOUNTER_GET_STATE_CLIENT_STALE_DATA")] EncounterGetStateClientStaleData = 3,
        [pbr::OriginalName("ENCOUNTER_GET_STATE_ERROR")] EncounterGetStateError = 4,
        [pbr::OriginalName("ENCOUNTER_GET_STATE_WC_PLAYER_NOT_IN_CHAMBER")] EncounterGetStateWcPlayerNotInChamber = 5,
        [pbr::OriginalName("ENCOUNTER_GET_STATE_WC_NOT_IN_PROGRESS")] EncounterGetStateWcNotInProgress = 6,
      }

      public sealed partial class EncounterGetStateStageResult : pb::IMessage<EncounterGetStateStageResult> {
        private static readonly pb::MessageParser<EncounterGetStateStageResult> _parser = new pb::MessageParser<EncounterGetStateStageResult>(() => new EncounterGetStateStageResult());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<EncounterGetStateStageResult> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::WUProtos.Networking.Responses.EncounterGetStateResponse.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public EncounterGetStateStageResult() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public EncounterGetStateStageResult(EncounterGetStateStageResult other) : this() {
          switch (other.TypeCase) {
            case TypeOneofCase.Swish:
              Swish = other.Swish.Clone();
              break;
            case TypeOneofCase.Combat:
              Combat = other.Combat.Clone();
              break;
          }

          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public EncounterGetStateStageResult Clone() {
          return new EncounterGetStateStageResult(this);
        }

        /// <summary>Field number for the "swish" field.</summary>
        public const int SwishFieldNumber = 1;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Types.EncounterGetStateSwishStageResult Swish {
          get { return typeCase_ == TypeOneofCase.Swish ? (global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Types.EncounterGetStateSwishStageResult) type_ : null; }
          set {
            type_ = value;
            typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.Swish;
          }
        }

        /// <summary>Field number for the "combat" field.</summary>
        public const int CombatFieldNumber = 2;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Types.EncounterGetStateCombatStageResult Combat {
          get { return typeCase_ == TypeOneofCase.Combat ? (global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Types.EncounterGetStateCombatStageResult) type_ : null; }
          set {
            type_ = value;
            typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.Combat;
          }
        }

        private object type_;
        /// <summary>Enum of possible cases for the "Type" oneof.</summary>
        public enum TypeOneofCase {
          None = 0,
          Swish = 1,
          Combat = 2,
        }
        private TypeOneofCase typeCase_ = TypeOneofCase.None;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public TypeOneofCase TypeCase {
          get { return typeCase_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void ClearType() {
          typeCase_ = TypeOneofCase.None;
          type_ = null;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as EncounterGetStateStageResult);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(EncounterGetStateStageResult other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(Swish, other.Swish)) return false;
          if (!object.Equals(Combat, other.Combat)) return false;
          if (TypeCase != other.TypeCase) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (typeCase_ == TypeOneofCase.Swish) hash ^= Swish.GetHashCode();
          if (typeCase_ == TypeOneofCase.Combat) hash ^= Combat.GetHashCode();
          hash ^= (int) typeCase_;
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
          if (typeCase_ == TypeOneofCase.Swish) {
            output.WriteRawTag(10);
            output.WriteMessage(Swish);
          }
          if (typeCase_ == TypeOneofCase.Combat) {
            output.WriteRawTag(18);
            output.WriteMessage(Combat);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (typeCase_ == TypeOneofCase.Swish) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Swish);
          }
          if (typeCase_ == TypeOneofCase.Combat) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Combat);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(EncounterGetStateStageResult other) {
          if (other == null) {
            return;
          }
          switch (other.TypeCase) {
            case TypeOneofCase.Swish:
              if (Swish == null) {
                Swish = new global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Types.EncounterGetStateSwishStageResult();
              }
              Swish.MergeFrom(other.Swish);
              break;
            case TypeOneofCase.Combat:
              if (Combat == null) {
                Combat = new global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Types.EncounterGetStateCombatStageResult();
              }
              Combat.MergeFrom(other.Combat);
              break;
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
                global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Types.EncounterGetStateSwishStageResult subBuilder = new global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Types.EncounterGetStateSwishStageResult();
                if (typeCase_ == TypeOneofCase.Swish) {
                  subBuilder.MergeFrom(Swish);
                }
                input.ReadMessage(subBuilder);
                Swish = subBuilder;
                break;
              }
              case 18: {
                global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Types.EncounterGetStateCombatStageResult subBuilder = new global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Types.EncounterGetStateCombatStageResult();
                if (typeCase_ == TypeOneofCase.Combat) {
                  subBuilder.MergeFrom(Combat);
                }
                input.ReadMessage(subBuilder);
                Combat = subBuilder;
                break;
              }
            }
          }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the EncounterGetStateStageResult message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static partial class Types {
          public sealed partial class EncounterGetStateSwishStageResult : pb::IMessage<EncounterGetStateSwishStageResult> {
            private static readonly pb::MessageParser<EncounterGetStateSwishStageResult> _parser = new pb::MessageParser<EncounterGetStateSwishStageResult>(() => new EncounterGetStateSwishStageResult());
            private pb::UnknownFieldSet _unknownFields;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pb::MessageParser<EncounterGetStateSwishStageResult> Parser { get { return _parser; } }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pbr::MessageDescriptor Descriptor {
              get { return global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Descriptor.NestedTypes[0]; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            pbr::MessageDescriptor pb::IMessage.Descriptor {
              get { return Descriptor; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public EncounterGetStateSwishStageResult() {
              OnConstruction();
            }

            partial void OnConstruction();

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public EncounterGetStateSwishStageResult(EncounterGetStateSwishStageResult other) : this() {
              _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public EncounterGetStateSwishStageResult Clone() {
              return new EncounterGetStateSwishStageResult(this);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override bool Equals(object other) {
              return Equals(other as EncounterGetStateSwishStageResult);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public bool Equals(EncounterGetStateSwishStageResult other) {
              if (ReferenceEquals(other, null)) {
                return false;
              }
              if (ReferenceEquals(other, this)) {
                return true;
              }
              return Equals(_unknownFields, other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override int GetHashCode() {
              int hash = 1;
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
              if (_unknownFields != null) {
                _unknownFields.WriteTo(output);
              }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public int CalculateSize() {
              int size = 0;
              if (_unknownFields != null) {
                size += _unknownFields.CalculateSize();
              }
              return size;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void MergeFrom(EncounterGetStateSwishStageResult other) {
              if (other == null) {
                return;
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
                }
              }
            }

          }

          public sealed partial class EncounterGetStateCombatStageResult : pb::IMessage<EncounterGetStateCombatStageResult> {
            private static readonly pb::MessageParser<EncounterGetStateCombatStageResult> _parser = new pb::MessageParser<EncounterGetStateCombatStageResult>(() => new EncounterGetStateCombatStageResult());
            private pb::UnknownFieldSet _unknownFields;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pb::MessageParser<EncounterGetStateCombatStageResult> Parser { get { return _parser; } }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public static pbr::MessageDescriptor Descriptor {
              get { return global::WUProtos.Networking.Responses.EncounterGetStateResponse.Types.EncounterGetStateStageResult.Descriptor.NestedTypes[1]; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            pbr::MessageDescriptor pb::IMessage.Descriptor {
              get { return Descriptor; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public EncounterGetStateCombatStageResult() {
              OnConstruction();
            }

            partial void OnConstruction();

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public EncounterGetStateCombatStageResult(EncounterGetStateCombatStageResult other) : this() {
              results_ = other.results_ != null ? other.results_.Clone() : null;
              _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public EncounterGetStateCombatStageResult Clone() {
              return new EncounterGetStateCombatStageResult(this);
            }

            /// <summary>Field number for the "results" field.</summary>
            public const int ResultsFieldNumber = 1;
            private global::WUProtos.Data.Combat.CombatResults results_;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public global::WUProtos.Data.Combat.CombatResults Results {
              get { return results_; }
              set {
                results_ = value;
              }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override bool Equals(object other) {
              return Equals(other as EncounterGetStateCombatStageResult);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public bool Equals(EncounterGetStateCombatStageResult other) {
              if (ReferenceEquals(other, null)) {
                return false;
              }
              if (ReferenceEquals(other, this)) {
                return true;
              }
              if (!object.Equals(Results, other.Results)) return false;
              return Equals(_unknownFields, other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public override int GetHashCode() {
              int hash = 1;
              if (results_ != null) hash ^= Results.GetHashCode();
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
              if (results_ != null) {
                output.WriteRawTag(10);
                output.WriteMessage(Results);
              }
              if (_unknownFields != null) {
                _unknownFields.WriteTo(output);
              }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public int CalculateSize() {
              int size = 0;
              if (results_ != null) {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(Results);
              }
              if (_unknownFields != null) {
                size += _unknownFields.CalculateSize();
              }
              return size;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            public void MergeFrom(EncounterGetStateCombatStageResult other) {
              if (other == null) {
                return;
              }
              if (other.results_ != null) {
                if (results_ == null) {
                  Results = new global::WUProtos.Data.Combat.CombatResults();
                }
                Results.MergeFrom(other.Results);
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
                    if (results_ == null) {
                      Results = new global::WUProtos.Data.Combat.CombatResults();
                    }
                    input.ReadMessage(Results);
                    break;
                  }
                }
              }
            }

          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
