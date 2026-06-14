# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def rightSideView(self, root: Optional[TreeNode]) -> List[int]:
        if root is None:
            return []

        result = []
        queue = deque()
        queue.append(root)

        while queue:
            level_size = len(queue)
            rightmost_value = None

            for i in range(level_size):
                node = queue.popleft()
                rightmost_value = node.val

                if node.left:
                    queue.append(node.left)

                if node.right:
                    queue.append(node.right)

            result.append(rightmost_value)

        return result