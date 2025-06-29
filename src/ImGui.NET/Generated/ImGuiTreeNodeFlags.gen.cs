namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiTreeNodeFlags
    {
        None = 0,
        Selected = 1,
        Framed = 2,
        AllowOverlap = 4,
        NoTreePushOnOpen = 8,
        NoAutoOpenOnLog = 16,
        DefaultOpen = 32,
        OpenOnDoubleClick = 64,
        OpenOnArrow = 128,
        Leaf = 256,
        Bullet = 512,
        FramePadding = 1024,
        SpanAvailWidth = 2048,
        SpanFullWidth = 4096,
        SpanLabelWidth = 8192,
        SpanAllColumns = 16384,
        LabelSpanAllColumns = 32768,
        NavLeftJumpsToParent = 131072,
        CollapsingHeader = 26,
        DrawLinesNone = 262144,
        DrawLinesFull = 524288,
        DrawLinesToNodes = 1048576,
    }
}
