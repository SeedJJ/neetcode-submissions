class Solution:
    def isValid(self, s: str) -> bool:
        check = []
        for c in s:
            if c == '(' or c == '{' or c == '[':
                check.append(c)
            else:
                if len(check) == 0:
                    return False

                left = check.pop()

                if not self.isParenthesesPair(left, c):
                    return False

        return len(check) == 0


    def isParenthesesPair(self, left: char, right: char) -> bool:
        if left == '(' and right == ')':
            return True
        elif left == '{' and right == '}':
            return True
        elif left == '[' and right == ']':
            return True
        else:
            return False