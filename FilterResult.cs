﻿using SharpDX;

namespace Stashie
{
    public class FilterResult
    {
        public CustomFilter Filter { get; }
        public ItemData ItemData { get; }
        public int StashIndex { get; }
        public Vector2 ClickPos { get; }

        public FilterResult(CustomFilter filter, ItemData itemData) {
            Filter = filter;
            ItemData = itemData;
            StashIndex = filter.StashIndexNode.Index;
            ClickPos = itemData.GetClickPosCache();
        }
    }
}