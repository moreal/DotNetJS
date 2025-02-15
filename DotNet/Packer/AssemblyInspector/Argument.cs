﻿namespace Packer;

internal record Argument
{
    public string Name { get; init; } = null!;
    public string Type { get; init; } = null!;
    public bool Nullable { get; init; }

    public override string ToString () => $"{Name}: {Type}";
}
