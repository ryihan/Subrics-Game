using System;
using UnityEngine;

namespace UnityEditor.Timeline
{
    static class AnimationClipExtensions
    {
        public static UInt64 ClipVersion(this AnimationClip clip)
        {
            if (clip == null)
                return 0;

            var info = AnimationClipCurveCache.Instance.GetCurveInfo(clip);
            var version = (UInt32) info.version;
            var count = (UInt32) info.curves.Length;
            var result = (UInt64) version;
            result |= ((UInt64) count) << 32;
            return result;
        }

