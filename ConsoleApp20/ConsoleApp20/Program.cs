using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            var numRouters1 = 7;
            var numLinks1 = 7;

            var links = new int[][]
                    {
                        new int[] { 0, 1 },
                        new int[] { 0, 2 },
                        new int[] { 1, 3 },
                        new int[] { 2, 3 },
                        new int[] { 2, 5 },
                        new int[] { 5, 6 },
                        new int[] { 3, 4 },

                    };

            //  var criticalNodes =GetCriticalNodes(links, numLinks1, numRouters1);

            var twoDi = new int[,]
            {
                {0,1,1,0,1 },
                {0,1,0,1,0 },
                {0,1,0,0,1 },
                {0,1,0,0,0 }
            };

            var minhourCode = MinHoursCode(4, 5, twoDi);



            var minhours = MinHours(twoDi);

        



            var r = minimumHours(4, 5, twoDi);

            var possible = new List<string> { "storage", "battery", "hover", "alex", "waterproof", "solar" };
            var r45 = new List<string> { "i am sharath battery", "manikanda alex", "bhartah battery", "jda alex", "waterproof good" };

            var popular = popularNFeatures(6
                , 2
                , possible
                , 7
                , r45
                );

            var countPrime = CountPrimes(10);
            var reverseBits = ReverseBits(43261596);
            Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3);
            var fact = TrailingZeroes(7);
            var titleNumber = TitleToNumber("AA");
            var majority = MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 });
            var converttotitile = ConvertToTitle(701);
            var twoSum = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            var missing = MissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 });
            var single1 = SingleNumber1(new int[] { 1, 2, 1, 3, 2, 5 });
            var single = SingleNumber(new int[] { 2, 2, 3, 2 });
            // var maxprofit = MaxProfit(new int[] {1, 2, 3, 4, 5 });
            var palidram = IsPalindrome("A man, a plan, a canal: Panama");
            var pascal1 = GetRow(3);
            var pascal = Generate(5);
            Console.ReadLine();
            var treeBST = SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 });
            //Given binary tree [3,9,20,null,null,15,7],
            TreeNode root = null;
            AddNewNode(ref root, 3);
            AddNewNode(ref root, 9);
            AddNewNode(ref root, 20);
            AddNewNode(ref root, 1);
            AddNewNode(ref root, 45);
            AddNewNode(ref root, 15);
            AddNewNode(ref root, 7);
            var lelev = LevelOrderBottom(root);
            var starir = ClimbStairs(5);
            var sqr = MySqrt(8);
            var binary = AddBinary("11", "1");
            var lastworkCount = LengthOfLastWord("  ");
            var maxsubarr = MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

            var inser = SearchInsert(new int[] { 1, 3, 5, 6 }, 2);
            var uni = RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
            var remove = RemoveDuplicates(new int[] { 1, 1, 2 });
            var isvalid = IsValid("()[]{}");
            var r1 = LongestCommonPrefix(new string[] { "aa", "a" });
            for (; ; )
            {
                Console.WriteLine("Enter your option");
                Console.WriteLine("1- For play \n 2- For Exit");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Roman Number");
                        var roman = Console.ReadLine();
                        var resultFromRoman = RomanToInt(roman);
                        Console.WriteLine(resultFromRoman);
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter Correct Option");
                        break;

                }
            }
        }
        static int time = 0;
        private static List<int> GetCriticalNodes(int[][] links, int numLinks, int numRouters)
        {
            time = 0;
            var map = new Dictionary<int, List<int>>();

            for (int i = 0; i < numRouters; i++)
            {
                map.Add(i, new List<int>());
            }
            foreach (var link in links)
            {
                map[link[0]].Add(link[1]);
                map[link[1]].Add(link[0]);
            }
            var set = new List<int>();
            var low = new int[numRouters];
            var ids = new int[numRouters];
            var parent = new int[numRouters];
            for (int i = 0; i < ids.Length; i++)
            {
                ids[i] = -1;

            }
            for (int i = 0; i < parent.Length; i++)
            {
                parent[i] = -1;

            }
            for (int i = 0; i < numRouters; i++)
            {
                if (ids[i] == -1)
                    DFS(map, low, ids, parent, i, set);
            }
            return set;
        }

        public static void DFS(Dictionary<int, List<int>> map, int[] low, int[] ids, int[] parent, int cur, List<int> res)
        {
            int children = 0;

            ids[cur] = low[cur] = ++time;

            foreach (int nei in map[cur])
            {
                if (ids[nei] == -1)
                {
                    children++;
                    parent[nei] = cur;
                    DFS(map, low, ids, parent, nei, res);
                    low[cur] = Math.Min(low[cur], low[nei]);
                    if ((parent[cur] == -1 && children > 1) || (parent[cur] != -1 && low[nei] >= ids[cur]))
                        res.Add(cur);
                }
                else if (nei != parent[cur])
                    low[cur] = Math.Min(low[cur], ids[nei]);
            }
        }
        public static int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0) return 0;

            int m = grid.Length;
            int n = grid[0].Length;

            int count = 0;

            bool[,] visited = new bool[m, n];

            List<int[]> dirs = new List<int[]>()
                                {
                                    new int[] {1, 0}, new int[] {-1, 0}, new int[] {0, 1}, new int[] {0, -1}
                                };

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == '1' && !visited[i, j])
                    {
                        BFS(grid, visited, i, j, dirs);
                        ++count;
                    }
                }
            }

            return count;
        }

        public static void BFS(char[][] grid, bool[,] visited, int i, int j, List<int[]> dirs)
        {
            var m = grid.Length;
            var n = grid[0].Length;

            var path = new Queue<Point>();

            path.Enqueue(new Point(i, j));

            while (path.Count != 0)
            {
                var head = path.Dequeue();

                foreach (var dir in dirs)
                {
                    int xx = head.X + dir[0];
                    int yy = head.Y + dir[1];
                    if (xx < 0 || xx >= m || yy < 0 || yy >= n || grid[xx][yy] == '0' || visited[xx, yy]) continue;
                    path.Enqueue(new Point(xx, yy));
                    visited[xx, yy] = true;
                }
            }
        }

        public class Point
        {
            public int X { get; }
            public int Y { get; }
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        public static uint ReverseBits(uint n)
        {
            var binary = string.Concat(Convert.ToString(n, 2).Reverse());
            return Convert.ToUInt32(binary, 2);
        }
        public static void Rotate(int[] nums, int k)
        {
            int[] a = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                a[(i + k) % nums.Length] = nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = a[i];
            }
        }
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var dict = new Dictionary<ListNode, int>();
            while (headA != null)
            {
                dict[headA] = headA.val;
                headA = headA.next;
            }
            while (headB != null)
            {
                if (dict.TryGetValue(headB, out int value))
                {
                    return headB;
                }
                headB = headB.next;
            }
            return null;
        }
        public static int TrailingZeroes(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n / 5;
                n /= 5;
            }
            return count;
        }
        public static int Fact(int n)
        {
            if (n == 0) return 1;
            return n * Fact(n - 1);
        }
        public static int TitleToNumber(string s)
        {
            var stringCharArray = s.ToArray();
            int result = 0;
            foreach (var item in stringCharArray)
            {
                var r = Math.Abs('A' - item) + 1;
                result = result * 26 + r;
            }
            return result;
        }
        public static int MajorityElement(int[] nums)
        {
            if (nums.Any() == false) return 0;
            var majority = nums.Length / 2;
            return nums.GroupBy(x => x).Where(x => x.Count() > majority).Select(x => x.Key).FirstOrDefault();
        }
        public static string ConvertToTitle(int n)
        {
            if (n <= 0) return string.Empty;
            var list = new List<char>();
            while (true)
            {
                n--;
                var div = n / 26;
                var rem = n % 26;
                list.Add((char)('A' + rem));
                if (div == 0)
                {
                    break;
                }
                n = div;
            }
            return string.Join("", list.ToArray().Reverse());
        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            int i = 0;
            int j = numbers.Length - 1;
            if (numbers.Any() == false) return default(int[]);
            while (i < j)
            {
                var sum = numbers[i] + numbers[j];
                if (sum > target)
                {
                    j--;
                }
                else if (sum < target)
                {
                    i++;
                }
                else
                {
                    return new int[] { i + 1, j + 1 };

                }
            }
            return default(int[]);
        }
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            var result = new List<string>();
            foreach (var item in list1)
            {
                if (list2.Contains(item))
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }
        public class MinStack
        {
            private Stack<int> _stack = new Stack<int>();
            public MinStack() { }
            public void Push(int x) { _stack.Push(x); }
            public void Pop() { _stack.Pop(); }
            public int Top() { return _stack.Peek(); }
            public int GetMin() { return _stack.Min(); }
        }
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;
            if (root.left == null && root.right == null) { return root.val == sum; }
            return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
        }
        public List<IList<int>> result = new List<IList<int>>();
        public List<int> item = new List<int>();
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            if (root == null) return new List<IList<int>>();
            if (root.left == null && root.right == null && root.val == sum)
            {
                item.Add(root.val);
            }
            PathSum(root.left, sum - root.val);
            result.Add(item);
            item = new List<int>();
            PathSum(root.right, sum - root.val);
            result.Add(item);
            return result;
        }

        public static List<string> popularNFeatures(int numFeatures,
                                        int topFeatures,
                                        List<string> possibleFeatures,
                                        int numFeatureRequests,
                                        List<string> featureRequests)
        {

            var resultSet = new Dictionary<string, int>();

            for (int i = 0; i < numFeatures; i++)
            {
                foreach (var item in featureRequests)
                {
                    if (item.Contains(possibleFeatures[i]))
                    {
                        if (resultSet.TryGetValue(possibleFeatures[i], out int value))
                        {
                            resultSet[possibleFeatures[i]]++;
                        }
                        else
                        {
                            resultSet.Add(possibleFeatures[i], 1);
                        }
                    }
                }
            }

            resultSet = resultSet.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            return resultSet.Take(topFeatures).Select(x => x.Key).ToList();

        }

        /*  var twoDi = new int[,]
            {
                {0,1,1,0,1 },
                {0,1,0,1,0 },
                {0,0,0,0,1 },
                {0,1,0,0,0 }
            };
            */

        public static IList<IList<int>> Generate(int numRows)
        {
            var db = new int[numRows, numRows];
            var item = new List<int>();
            var result = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == j)
                    {
                        db[i, j] = 1;
                        item.Add(db[i, j]);
                    }
                    else
                    {
                        db[i, j] = db[i - 1, j - 1] + db[i - 1, j];
                        item.Add(db[i, j]);
                    }
                }
                result.Add(item);
                item = new List<int>();
            }
            return result;
        }
        public static int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right && left < nums.Length && right >= 0)
            {
                int mid = left + (right - left) / 2;
                if (target == nums[mid])
                {
                    return mid;
                }
                if (nums[left] <= nums[mid] && nums[left] <= target && target <= nums[mid])
                {
                    right = mid;
                }
                else if (nums[left] <= nums[mid])
                {
                    left = mid + 1;
                }
                else if (nums[right] >= nums[mid] && nums[mid] <= target && target <= nums[right])
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
        public static bool Search1(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right && left < nums.Length && right >= 0)
            {
                int mid = left + (right - left) / 2;
                if (target == nums[mid])
                {
                    return true;
                }
                if (nums[left] <= nums[mid] && nums[left] <= target && target <= nums[mid])
                {
                    right = mid;
                }
                else if (nums[left] <= nums[mid])
                {
                    left = mid + 1;
                }
                else if (nums[right] >= nums[mid] && nums[mid] <= target && target <= nums[right])
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return false;
        }
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            s = System.Text.RegularExpressions.Regex.Replace(s, @"[^0-9a-zA-Z]+", "").ToLower();
            int j = s.Length - 1;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (i < j && s[i] == s[j--]) continue;
                else return false;
            }
            return true;
        }
        //[7,1,5,3,6,4]
        //[1,2,3,4,5]
        public int MaxProfit(int[] prices)
        {
            var max = 0;
            var min = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (min < prices[i])
                {
                    min = prices[i];
                }
                else
                {
                    max = Math.Max(prices[i] - min, max);
                }
            }
            return max;
        }
        //[7,1,5,3,6,4]
        //[1,2,3,4,5]
        public static int MaxProfit2(int[] prices)
        {
            if (prices.Any() == false) return 0;

            var max = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                var cur = prices[i];
                var next = prices[i + 1];
                if (next > cur)
                    max += next - cur;
            }
            return max;
        }
        public static int SingleNumber(int[] nums)
        {
            if (nums.Any() == false) return 0;
            Array.Sort(nums);
            int find = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i < nums.Length - 2 && nums[i] == nums[i + 1] && nums[i + 1] == nums[i + 2])
                {
                    i += 2;
                }
                else
                {
                    find = i;
                }

            }
            return find >= 0 ? nums[find] : 0;
        }
        public static int[] SingleNumber1(int[] nums)
        {
            var result = new List<int>();
            if (nums.Any() == false) return result.ToArray();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (i < nums.Length - 1 && nums[i] == nums[i + 1])
                {
                    i++;
                }
                else
                {
                    result.Add(nums[i]);
                }

            }
            return result.ToArray();
        }
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;
            var slwPtr = head;
            var fastPtr = head.next.next;
            while (slwPtr != fastPtr)
            {
                slwPtr = slwPtr.next;
                fastPtr = fastPtr.next?.next;

            }
            return slwPtr == fastPtr ? true : false;
        }
        public static int MissingNumber(int[] nums)
        {
            int sum = 0;
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                total += (i + 1);
            }
            return total - sum;
        }
        public static bool Search2(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (target == nums[i]) return true;
            }
            return false;
        }
        public static IList<int> GetRow(int numRows)
        {
            var db = new int[numRows, numRows];
            var item = new List<int>();
            var result = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == j)
                    {
                        db[i, j] = 1;
                        if (i == (numRows - 1))
                            item.Add(db[i, j]);
                    }
                    else
                    {
                        db[i, j] = db[i - 1, j - 1] + db[i - 1, j];
                        if (i == (numRows - 1))
                            item.Add(db[i, j]);
                    }
                }
                result.Add(item);
                item = new List<int>();
            }
            return result.LastOrDefault();
        }
        public int PathSum1(TreeNode root, int sum)
        {
            if (root == null) return default(int);
            if (root.left == null && root.right == null && root.val == sum)
            {
                return root.val;
            }
            item.Add(PathSum1(root.left, sum - root.val));
            item = new List<int>();
            PathSum1(root.right, sum - root.val);
            return 0;
        }
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            if (root == null) { return new List<IList<int>>(); }
            var queue = new Queue<TreeNode>();
            var item = new List<int>();
            var result = new List<IList<int>>();
            queue.Enqueue(root);
            queue.Enqueue(null);
            while (queue.Any())
            {
                var temp = queue.Dequeue();
                if (temp == null)
                {
                    if (queue.Any()) { queue.Enqueue(null); }
                    result.Add(item);
                    item = new List<int>();
                    continue;
                }
                item.Add(temp.val);
                if (temp.left != null)
                {
                    queue.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }
            }
            var arrayResult = result.ToArray();
            for (int i = 0; i < arrayResult.Length; i++)
            {
                if (i % 2 != 0)
                {
                    arrayResult[i] = arrayResult[i].Reverse().ToArray();
                }
            }
            return arrayResult;
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }

            var queue = new Queue<TreeNode>();
            var item = new List<int>();
            var result = new List<IList<int>>();
            queue.Enqueue(root);
            queue.Enqueue(null);
            while (queue.Any())
            {
                var temp = queue.Dequeue();

                if (temp == null)
                {
                    if (queue.Any())
                    {
                        queue.Enqueue(null);
                    }

                    result.Add(item);
                    item = new List<int>();
                    continue;
                }

                item.Add(temp.val);

                if (temp.left != null)
                {
                    queue.Enqueue(temp.left);

                }
                if (temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }

            }
            return result;
        }
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            var left = MinDepth(root.left);
            var right = MinDepth(root.right);

            if (left == 0 || right == 0)
            {
                return left + right + 1;
            }

            return left < right ? left + 1 : right + 1;
        }
        public int MinDepthIte(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var queue = new Queue<TreeNode>();
            int dep = 0;
            queue.Enqueue(root);
            queue.Enqueue(null);
            while (queue.Any())
            {
                var temp = queue.Dequeue();

                if (temp == null)
                {
                    dep++;
                    queue.Enqueue(null);
                    continue;
                }
                if (temp.left == null && temp.right == null)
                {
                    return dep + 1;
                }

                if (temp.left != null)
                {
                    queue.Enqueue(temp.left);

                }
                if (temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }

            }
            return dep + 1;
        }

        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            int left = BalancedTree(root.left);
            int right = BalancedTree(root.right);
            if (Math.Abs(left - right) > 1) return false;
            return IsBalanced(root.left) && IsBalanced(root.right);
        }
        public int BalancedTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = BalancedTree(root.left);
            int right = BalancedTree(root.right);

            if (left > right)
            {
                return left + 1;
            }
            return right + 1;
        }
        public int Balanced(TreeNode root)
        {
            if (root == null) return 0;
            return 1 + Math.Abs(Balanced(root.left) - Balanced(root.right));
        }
        public TreeNode SortedListToBST(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return new TreeNode(head.val);
            var nums = new List<int>();
            var temp = head;
            while (temp != null)
            {
                nums.Add(temp.val);
                temp = temp.next;
            }
            return SortedArrayToBST(nums.ToArray());
        }

        public static TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0) return null;
            if (nums.Length == 1) return new TreeNode(nums[0]);
            var root = new TreeNode(nums[nums.Length / 2]);
            root.left = SortedArrayToBST(nums.Take(nums.Length / 2).ToArray());
            root.right = SortedArrayToBST(nums.Skip((nums.Length / 2) + 1).Take(nums.Length).ToArray());
            return root;
        }
        public TreeNode SortedListToBSTMethod2(ListNode head)
        {
            if (head == null) return null;
            return RecursiveBST(head);
        }

        public TreeNode RecursiveBST(ListNode head)
        {
            if (head == null) return null;

            ListNode prev = null, slow = head, fast = head;

            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            TreeNode root = new TreeNode(slow.val);
            if (prev == null) return root;

            prev.next = null;
            root.left = RecursiveBST(head);
            root.right = RecursiveBST(slow.next);
            return root;
        }


        public static void AddNewNode(ref TreeNode root, int? data)
        {
            TreeNode newNode;
            if (data == null)
            {
                newNode = null;
            }
            else
            {
                newNode = new TreeNode(data.Value);
            }
            if (root == null)
            {
                root = newNode;
                return;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                var temp = queue.Dequeue();

                if (temp.left != null)
                {
                    queue.Enqueue(temp.left);
                }
                else
                {
                    temp.left = newNode;
                    queue = new Queue<TreeNode>();
                    break;
                }

                if (temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }
                else
                {
                    temp.right = newNode;
                    queue = new Queue<TreeNode>();
                    break;
                }
            }
        }


        public static IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            if (root == null) return null;

            var queue = new Queue<TreeNode>();

            var list = new List<int>();
            var result = new List<IList<int>>();
            queue.Enqueue(root);
            queue.Enqueue(null);
            while (queue.Any())
            {
                var temp = queue.Dequeue();

                if (temp == null)
                {
                    if (queue.Any())
                    {
                        queue.Enqueue(null);
                    }
                    result.Add(list);
                    list = new List<int>();
                }
                else
                {
                    list.Add(temp.val);
                    if (temp.left != null)
                    {
                        queue.Enqueue(temp.left);
                    }
                    if (temp.right != null)
                    {
                        queue.Enqueue(temp.right);
                    }
                }


            }
            var r = result.ToArray().Reverse().ToList();
            return r;

        }
        public bool IsSymmetric(TreeNode root)
        {
            return IsMirror(root, root);

        }
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            return 1 + MaxDepth(root.left) + MaxDepth(root.right);
        }
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);

        }
        public bool IsMirror(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            return p.val == q.val && IsSameTree(p.left, q.right) && IsSameTree(p.right, q.left);
        }

        public bool IsSameTreeWIthIte(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            var q1 = new Queue<TreeNode>();
            var q2 = new Queue<TreeNode>();
            q1.Enqueue(p);
            q2.Enqueue(q);

            while (q1.Any() && q2.Any())
            {
                var temp1 = q1.Dequeue();
                var temp2 = q2.Dequeue();
                if (temp1.val != temp2.val) return false;

                if (temp1.left != null && temp2.left != null)
                {
                    q1.Enqueue(temp1.left);
                    q2.Enqueue(temp2.left);
                }
                else if (temp1.left != null || temp2.left != null)
                {
                    return false;
                }
                if (temp1.right != null && temp2.right != null)
                {
                    q1.Enqueue(temp2.right);
                    q2.Enqueue(temp2.right);
                }
                else if (temp1.right != null || temp2.right != null)
                {
                    return false;
                }
            }

            return q1.Any() == false && q1.Any() == false ? true : false;

        }
        public static string AddBinary(string a, string b)
        {
            if (string.IsNullOrEmpty(a)) return b;
            if (string.IsNullOrEmpty(b)) return a;
            var num1 = Convert.ToUInt32(a, 2);
            var num2 = Convert.ToUInt32(b, 2);
            var result = num1 + num2;
            return Convert.ToString(result, 2);


        }
        public static int ClimbStairs(int n)
        {
            int[] result = new int[n + 1];
            result[0] = 1;
            result[1] = 1;
            int i = 2;
            while (i <= n)
            {
                result[i] = result[i - 1] + result[i - 2];
                i++;
            }
            return result[n];
        }
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            Array.Sort(nums1);

        }
        public static ListNode DeleteDuplicates(ListNode head)
        {
            var cur = head;
            while (cur.next != null)
            {
                if (cur.val == cur.next.val)
                {
                    cur.next = cur.next.next;
                }
                cur = cur.next;
            }
            return head;

        }
        public static int MySqrt(int x)
        {
            var r = Math.Floor(Math.Sqrt(x));
            return Convert.ToInt32(r);
        }
        public static int[] PlusOne(int[] digits)
        {
            int i = digits.Length - 1;
            while (i >= 0)
            {
                if (digits[i] <= 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i--] = 0;
            }

            int[] newArray = new int[digits.Length + 1];
            newArray[0] = 1;
            return newArray;
        }

        public static int LengthOfLastWord(string s)
        {
            s = s.TrimEnd();
            if (string.IsNullOrEmpty(s)) return 0;
            var stringBySpace = s.Split(' ');
            return stringBySpace.Last().Count();
        }
        public static int MaxSubArray(int[] nums)
        {
            int sum = nums[0], max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
                sum = nums[i] > sum ? nums[i] : sum;
                max = Math.Max(sum, max);
            }
            return max;
        }
        public static int RomanToInt(string s)
        {
            var dict = new Dictionary<char, int>() {
                { 'I', 1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 },

            };

            var value = 0;
            var result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.TryGetValue(s[i], out value))
                {
                    result += value;
                }
            }

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == 'I' && (s[i + 1] == 'V' || s[i + 1] == 'X')) result -= 2;
                if (s[i] == 'X' && (s[i + 1] == 'L' || s[i + 1] == 'C')) result -= 20;
                if (s[i] == 'C' && (s[i + 1] == 'D' || s[i + 1] == 'M')) result -= 200;

            }
            return result;

        }


        public static bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            if (s.Length % 2 != 0) return false;

            var charArray = s.ToCharArray();
            var stack = new Stack<char>();
            for (int i = 0; i < charArray.Length; i++)
            {
                switch (charArray[i])
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case '{':
                        stack.Push('}');
                        break;
                    default:
                        if (stack.Any() && charArray[i] == stack.Peek())
                        {
                            stack.Pop();
                        }
                        else { return false; }
                        break;
                }

            }

            return stack.Any() ? false : true;
        }

        public static int CountPrimes(int n)
        {
            bool[] isPrime = new bool[n];
            for (int i = 2; i < n; i++)
            {
                isPrime[i] = true;
            }
            for (int i = 2; i * i < n; i++)
            {
                if (!isPrime[i]) continue;
                for (int j = i * i; j < n; j += i)
                {
                    isPrime[j] = false;
                }
            }
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (isPrime[i]) count++;
            }
            return count;
        }

        public int generalizedGCD(int num, int[] arr)
        {
            int result = arr[0];
            for (int i = 1; i < num; i++)
            {
                result = gcd(arr[i], result);

                if (result == 1)
                {
                    return 1;
                }
            }
            return result;
        }

        int gcd(int a, int b)
        {
            if (a == 0) return b;
            return gcd(b % a, a);
        }


        public static int[] cellCompete(int[] states, int days)
        {
            int n = states.Length;
            int[] temp = new int[n];
            for (int i = 0; i < n; i++)
                temp[i] = states[i];
            int k = days;
            while (k-- > 0)
            {
                temp[0] = 0 ^ states[1];
                temp[n - 1] = 0 ^ states[n - 2];
                for (int i = 1; i <= n - 2; i++)
                    temp[i] = states[i - 1] ^ states[i + 1];
                for (int i = 0; i < n; i++)
                    states[i] = temp[i];
            }
            return states;
        }




        public int orangesRotting(int[][] grid)
        {
            int R = grid.Length, C = grid[0].Length;
            Queue<int> queue = new Queue<int>();
            Dictionary<int, int> depth = new Dictionary<int, int>();
            for (int r = 0; r < R; ++r)
                for (int c = 0; c < C; ++c)
                    if (grid[r][c] == 2)
                    {
                        int code = r * C + c;
                        queue.Enqueue(code);
                        depth.Add(code, 0);
                    }

            int ans = 0;
            while (queue.Any())
            {
                int code = queue.Dequeue();
                int r = code / C, c = code % C;
                for (int k = 0; k < 4; ++k)
                {
                    int nr = r + dr[k];
                    int nc = c + dc[k];
                    if (0 <= nr && nr < R && 0 <= nc && nc < C && grid[nr][nc] == 1)
                    {
                        grid[nr][nc] = 2;
                        int ncode = nr * C + nc;
                        queue.Enqueue(ncode);
                        depth.Add(ncode, depth[code] + 1);
                        ans = depth[ncode];
                    }
                }
            }

            foreach (var row in grid)
            {
                foreach (var item in row)
                {
                    if (item == 1)
                        return -1;
                }

            }
            return ans;

        }

        static int[] dr = new int[] { -1, 0, 1, 0 };
        static int[] dc = new int[] { 0, -1, 0, 1 };
        public static int minimumHours(int rows, int columns, int[,] grid)
        {
            var queue = new Queue<int>();
            var depth = new Dictionary<int, int>();
            for (int r = 0; r < rows; ++r)
                for (int c = 0; c < columns; ++c)
                    if (grid[r, c] == 1)
                    {
                        int code = r * columns + c;
                        queue.Enqueue(code);
                        depth.Add(code, 0);
                    }

            int ans = 0;
            while (queue.Any())
            {
                int code = queue.Dequeue();
                int r = code / columns;
                int c = code % columns;
                for (int k = 0; k < 4; ++k)
                {
                    int nr = r + dr[k];
                    int nc = c + dc[k];
                    if (0 <= nr && nr < rows && 0 <= nc && nc < columns && grid[nr, nc] == 1)
                    {
                        grid[nr, nc] = 2;
                        int ncode = nr * columns + nc;
                        queue.Enqueue(ncode);
                        depth.Add(ncode, depth[code] + 1);
                        ans = depth[ncode];
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (grid[i, j] == 1) return -1;
                }
            }
            return ans;
        }
        public static int MinHours(int[,] grid)
        {
            var rows = grid.GetLength(0);
            var cols = grid.GetLength(1);
            var filesInServer = new List<int[]>();
            int numDays = 0;

            int[,] dirs = { { 0, -1 }, { 0, 1 }, { 1, 0 }, { -1, 0 } };

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        filesInServer.Add(new int[] { i, j });
                    }
                }
            }
            while (filesInServer.Count != grid.Length)
            {
                numDays = 1;
                for (int i = 0; i < filesInServer.Count; i++)
                {
                    int gridRow = 0, gridCol = 0;
                    for (int j = 0; j < 4; j++)
                    {
                        gridRow = filesInServer[i][0] + dirs[j, 0];
                        gridCol = filesInServer[i][1] + dirs[j, 1];
                        if (gridRow >= 0 && gridRow < rows && gridCol >= 0 && gridCol < cols)
                        {
                            if (grid[gridRow, gridCol] == 0)
                            {
                                grid[gridRow, gridCol] = 1;
                                filesInServer.Add(new int[] { gridRow, gridCol });
                            }

                        }
                    }

                }
                numDays++;

            }

            return numDays;
        }


        /* def minHour(self, rows, columns, grid):
         if not rows or not columns:
             return 0

         q = [[i, j] for i in range(rows) for j in range(columns) if grid[i][j]==1]
         directions = [[1,0],[-1,0],[0,1],[0,-1]]
         time = 0

         while True:
             new = []
             for [i, j] in q:
                 for d in directions:
                     ni, nj = i + d[0], j + d[1]
                     if 0 <= ni<rows and 0 <= nj<columns and grid[ni][nj] == 0:
                         grid[ni][nj] = 1
                         new.append([ni, nj])
             q = new
             if not q:
                 break
             time += 1

         return time */



        public static int MinHoursCode(int rows, int columns, int[,] grid)
        {
            if (rows == 0 || columns == 0) return 0;

            var q = new List<int[]>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        q.Add(new int[] { i, j });
                    }
                }
            }

            var directions = new List<int[]>{ new int[] { 1, 0 },  new int[] {-1, 0 }, new int[] { 0, 1 }, new int[] { 0,-1 }};
            var time = 0;
           
            while (true)
            {
                var newResult = new List<int[]>();
                foreach (var item in q)
                {
                    foreach (var d in directions)
                    {
                        var ni = item[0] + d[0];
                        var nj = item[1] + d[1];
                        if (0 <= ni && ni < rows && 0 <= nj && nj < columns && grid[ni, nj] == 0)
                        {
                            grid[ni, nj] = 1;
                            newResult.Add(new int[] { ni, nj });
                        }
                    }
                }
                q = newResult;
                if (q.Any() == false) break;
                time += 1;
            }
            return time;
        }




        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var dict = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (dict[s[i]] != t[i]) return false;
                }
                else if (dict.ContainsValue(t[i])) return false;
                else dict.Add(s[i], t[i]);
            }
            return true;
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            if ((strs == null) || (strs.Length < 1))
            {
                return "";
            }

            var shortString = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i].Length < shortString.Length)
                {
                    shortString = strs[i];
                }
            }

            for (int i = 0; i < shortString.Length; i++)
            {
                var ch = shortString[i];
                for (int j = 0; j < strs.Length; j++)
                {
                    if (ch != strs[j][i])
                    {
                        return shortString.Substring(0, i);
                    }
                }
            }
            return shortString;
        }
        public static int[] TwoSum1(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[] { dict[target - nums[i]], i };
                }
                dict[nums[i]] = i;
            }
            return null;
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i != 0 && nums[i] == nums[i - 1]) continue;
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    var sum = nums[i] + nums[j] + nums[k];
                    if (sum > 0) k--;
                    else if (sum < 0) j++;
                    else
                    {
                        var item = new List<int>() { nums[i], nums[j], nums[k] };
                        result.Add(item);
                        j++;
                        k--;
                        while (j < k && nums[j] == nums[j - 1]) j++;
                        while (k > j && nums[k] == nums[k + 1]) k--;

                    }
                }
            }
            return result;
        }



        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();
            if (nums == null || nums.Length < 4) { return result; }
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) { continue; }

                if (nums[i] + nums[nums.Length - 3] + nums[nums.Length - 2] + nums[nums.Length - 1] < target) { continue; }
                if (nums[i] + nums[i + 1] + nums[i + 2] + nums[i + 3] > target) { return result; }
                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) { continue; }
                    if (nums[i] + nums[j] + nums[nums.Length - 2] + nums[nums.Length - 1] < target) { continue; }
                    if (nums[i] + nums[j] + nums[j + 1] + nums[j + 2] > target) { break; }

                    int leftIdx = j + 1;
                    int rightIdx = nums.Length - 1;

                    while (leftIdx < rightIdx)
                    {
                        int sum = nums[i] + nums[j] + nums[leftIdx] + nums[rightIdx];
                        if (sum > target) { rightIdx--; }
                        else if (sum < target) { leftIdx++; }
                        else
                        {
                            result.Add(new List<int>() { nums[i], nums[j], nums[leftIdx], nums[rightIdx] });
                            int tmpLeft = nums[leftIdx];
                            int tmpRight = nums[rightIdx];
                            do { rightIdx--; } while (leftIdx < rightIdx && nums[rightIdx] == tmpRight);
                            do { leftIdx++; } while (leftIdx < rightIdx && nums[leftIdx] == tmpLeft);
                        }

                    }
                }
            }
            return result;
        }

        public static long Reverse(int x)
        {
            long result = 0;
            for (; x != 0; x /= 10)
            {
                result = result * 10 + x % 10;
            }
            if (result > int.MaxValue || result < int.MinValue) result = 0;
            return (int)result;

        }

        public static int MyAtoi(string str)
        {
            var result = str.Trim().Split(' ');
            var intResult = 0;
            int r = int.Parse("-91283472332");
            if (intResult < int.MinValue) return int.MinValue;
            else if (intResult > int.MaxValue) return int.MaxValue;
            return intResult;
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int i = 1;
            int unique = 1;
            while (nums.Length > i)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[unique++] = nums[i++];
                }
                else { i++; }
            }
            return unique;
        }
        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            int unique = 0;
            while (nums.Length > i)
            {
                if (nums[i] != val)
                {
                    nums[unique++] = nums[i++];

                }
                else
                {
                    i++;
                }
            }

            return unique;

        }
        public static int SearchInsert(int[] nums, int target)
        {
            int i = 0;
            for (i = 0; i < nums.Length && nums[i] <= target; i++)
            {
                if (nums[i] == target) return i;
            }
            return i;

        }
        public static int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) return 0;
            if (string.IsNullOrEmpty(haystack)) return -1;
            return haystack.IndexOf(needle);

        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }


        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public class Solution
        {
            public ListNode MergeTwoLists(ListNode l1, ListNode l2)
            {

                if (l1 == null) return l2;
                if (l2 == null) return l1;

                var arrayItem = new List<int>();
                while (l1 != null || l2 != null)
                {
                    if (l1 != null)
                    {
                        arrayItem.Add(l1.val);
                        l1 = l1.next;
                    }
                    if (l2 != null)
                    {
                        arrayItem.Add(l2.val);
                        l2 = l2.next;
                    }
                }
                arrayItem.Sort();
                ListNode listNode = null;
                ListNode temp = null;
                foreach (var item in arrayItem)
                {
                    var newNode = new ListNode(item)
                    {
                        next = null
                    };
                    if (listNode == null)
                    {
                        temp = listNode = newNode;
                    }
                    else
                    {
                        temp.next = newNode;
                        temp = newNode;
                    }
                }
                return listNode;
            }
        }
    }
}
