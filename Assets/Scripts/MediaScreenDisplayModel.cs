using System.Collections;
using System.Collections.Generic;
using Normal.Realtime.Serialization;
using UnityEngine;
using Normal.Realtime;

[RealtimeModel]
public partial class MediaScreenDisplayModel
{
    [RealtimeProperty(1, true)] private RealtimeArray<MediaScreenDisplayStateModel> _mediaScreenDisplayStates;
}

/* ----- Begin Normal Autogenerated Code ----- */
public partial class MediaScreenDisplayModel : RealtimeModel {
    public Normal.Realtime.Serialization.RealtimeArray<MediaScreenDisplayStateModel> mediaScreenDisplayStates {
        get { return _mediaScreenDisplayStates; }
    }
    
    public enum PropertyID : uint {
        MediaScreenDisplayStates = 1,
    }
    
    public MediaScreenDisplayModel() : this(null) {
    }
    
    public MediaScreenDisplayModel(RealtimeModel parent) : base(null, parent) {
        RealtimeModel[] childModels = new RealtimeModel[1];
        
        _mediaScreenDisplayStates = new Normal.Realtime.Serialization.RealtimeArray<MediaScreenDisplayStateModel>();
        childModels[0] = _mediaScreenDisplayStates;
        
        SetChildren(childModels);
    }
    
    protected override int WriteLength(StreamContext context) {
        int length = 0;
        length += WriteStream.WriteCollectionLength((uint)PropertyID.MediaScreenDisplayStates, _mediaScreenDisplayStates, context);
        return length;
    }
    
    protected override void Write(WriteStream stream, StreamContext context) {
        stream.WriteCollection((uint)PropertyID.MediaScreenDisplayStates, _mediaScreenDisplayStates, context);
    }
    
    protected override void Read(ReadStream stream, StreamContext context) {
        while (stream.ReadNextPropertyID(out uint propertyID)) {
            switch (propertyID) {
                case (uint)PropertyID.MediaScreenDisplayStates: {
                    stream.ReadCollection(_mediaScreenDisplayStates, context);
                    break;
                }
                default: {
                    stream.SkipProperty();
                    break;
                }
            }
        }
    }
    
}
/* ----- End Normal Autogenerated Code ----- */
