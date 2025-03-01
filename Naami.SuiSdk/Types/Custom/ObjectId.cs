﻿namespace Naami.SuiSdk.Types.Custom;

public readonly struct ObjectId
{
    private readonly string? _objectId;

    public ObjectId(string? objectId)
    {
        // TODO: objectId format validation
        
        _objectId = objectId;
    }

    public override string? ToString() => _objectId;

    public static implicit operator ObjectId(string? objectId) => new(objectId);
    public static implicit operator string?(ObjectId objectId) => objectId.ToString();
}