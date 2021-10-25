using System.Collections;
using System.Linq;
using NUnit.Framework;
using UnityEngine;

public class TextEditorTests
{
    TextEditor m_TextEditor;

    static IEnumerable textWithCodePointBoundaryIndices
    {
        get
        {
            yield return new TestCaseData("", new[] { 0 });
            yield return new TestCaseData("abc", new[] { 0, 1, 2, 3 });
            yield return new TestCaseData("\U0001f642", new[] { 0, 2 }).SetName("(U+1F642)");
            yield return new TestCaseData("\U0001f642\U0001f643", new[] { 0, 2, 4 }).SetName("(U+1F642)(U+1F643)");
            yield return new TestCaseData("a\U0001f642b\U0001f643c", new[] { 0, 1, 3, 4, 6, 7 }).SetName("a(U+1F642)b(U+1F643)c");
            yield return new TestCaseData("Hello 😁 World", new[] { 0, 1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12, 13, 14 }).SetName("Hello (U+1F601) World");
            yield return new TestCaseData("見ざる🙈、聞かざる🙉、言わざる🙊", new[] { 0, 1, 2, 3, 5, 6, 7, 8, 9, 10, 12, 13, 14, 15, 16, 17, 19 }).SetName("Three wise monkeys");
