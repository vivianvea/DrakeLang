﻿//------------------------------------------------------------------------------
// VSharp - Viv's C#-esque sandbox.
// Copyright (C) 2019  Vivian Vea
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.
//------------------------------------------------------------------------------

namespace VSharp.Syntax
{
    public enum SyntaxKind
    {
        // Tokens

        BadToken,
        EndOfFileToken,
        IntegerToken,
        FloatToken,
        StringToken,
        CharToken,
        ColonToken,
        SemicolonToken,
        PlusToken,
        PlusPlusToken,
        PlusEqualsToken,
        MinusToken,
        MinusMinusToken,
        MinusEqualsToken,
        StarToken,
        StarEqualsToken,
        SlashToken,
        SlashEqualsToken,
        PercentToken,
        BangToken,
        TildeToken,
        HatToken,
        EqualsToken,
        AmpersandToken,
        AmpersandAmpersandToken,
        AmpersandEqualsToken,
        PipeToken,
        PipePipeToken,
        PipeEqualsToken,
        PipeGreaterToken,
        EqualsEqualsToken,
        BangEqualsToken,
        LessEqualsToken,
        GreaterEqualsToken,
        LessToken,
        GreaterToken,
        EqualsGreaterToken,
        OpenParenthesisToken,
        CloseParenthesisToken,
        OpenBraceToken,
        CloseBraceToken,
        IdentifierToken,
        DotToken,
        CommaToken,
        UnderscoreToken,
        WhitespaceToken,
        LineCommentToken,
        MultiLineCommentToken,

        // Keywords

        ObjectKeyword,
        BoolKeyword,
        IntKeyword,
        FloatKeyword,
        StringKeyword,
        CharKeyword,
        VarKeyword,
        SetKeyword,
        TrueKeyword,
        FalseKeyword,
        DefKeyword,
        NamespaceKeyword,
        IfKeyword,
        ElseKeyword,
        WhileKeyword,
        ForKeyword,
        ReturnKeyword,
        WithKeyword,
        ContinueKeyword,
        BreakKeyword,
        TypeofKeyword,
        NameofKeyword,

        // Nodes

        CompilationUnit,
        Parameter,

        // Declaration statements

        NamespaceDeclaration,
        MethodDeclaration,

        // Statements

        WithNamespaceStatement,
        BlockStatement,
        VariableDeclarationStatement,
        IfStatement,
        ElseStatement,
        WhileStatement,
        ForStatement,
        GoToKeyword,
        GoToStatement,
        LabelStatement,
        ReturnStatement,
        ContinueStatement,
        BreakStatement,
        BlockBodyStatement,
        ExpressionBodyStatement,
        ExpressionStatement,

        // Expressions

        LiteralExpression,
        NameExpression,
        UnaryExpression,
        BinaryExpression,
        ParenthesizedExpression,
        TypeofExpression,
        NameofExpression,
        TypeExpression,
        AssignmentExpression,
        CallExpression,
        ExplicitCastExpression,
    }
}