﻿using VkScriptAnalyzer.Lexer;

namespace VkScriptAnalyzer.Parser
{
    public class Node
    {
        public Node Next { get; set; }
    }

    public class VarNode : Node
    {
        public Token Id { get; set; }
        public Node Expression { get; set; }
    }

    public class AssignNode : Node
    {
        public AssignNode(Token token)
        {
            Id = token;
        }

        public Token Id { get; set; }
        public ExprNode Expression { get; set; }
    }

    public class IfNode : Node
    {
        public ExprNode Condition { get; set; }
        public Node Block { get; set; }
        public Node Else { get; set; }
    }

    public class ExprNode : Node
    {
        public ExprNode(Token token)
        {
            this.token = token;
        }

        public Token token { get; set; }

        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
