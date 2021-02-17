using System;
using UnityEngine;

public sealed class CaughtPlayerEventArgs : EventArgs
{
    public Color Color { get; }
    public CaughtPlayerEventArgs(Color Color)
    {
        Color = Color;
    }
}
