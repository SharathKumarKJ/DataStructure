using System;
using System.Collections;
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
            var mergeValues = new int[][]
            {
                new int[]  {1,3},
                new int[]  {2,6},
                new int[]  {8,10},
                new int[]  {15,18},


              };

            var mergeResult = Merge(mergeValues);

            var value1 = new int[][]
                   {
                            new int[]  {0,2},
                            new int[]  {5,10},
                            new int[]  {13,23},
                            new int[]  {24,25},


                   };
            var value2 = new int[][]
                  {
                            new int[]  {1,5},
                            new int[]  {8,12},
                            new int[]  {15,24},
                            new int[]  {25,26},


                  };
            var intervalIntersection = IntervalIntersection(value1, value2);

         

            var mostcommanWord = MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" });
            var board = new char[][]
           {
                new char[]  {'o','a','a','n'},
                new char[]  {'e','t','a','e'},
                new char[]  {'i','h','k','r'},
                new char[]  {'i','f','l','v'},

           };

           var board1 = new char[][]
           {
                new char[]  {'a','a'},
              

           };
            var foundWord1 = FindWords(board1, "a");

            var foundWords = FindWordsWithTrie(board, new string[] { "oath", "pea", "eat", "rain" });
          

            // ["WordDictionary","addWord","addWord","addWord","addWord","search","search","addWord","search","search","search","search","search","search"]
            //       [[],["at"],["and"],["an"],["add"],              ["a"],[".at"],["bat"],

            // [".at"],["an."],["a.d."],["b."],["a.d"],["."]]

            // Expected [null,null,null,null,null,false,false,null,true,true,false,false,true,false]
            // outcome  [null,null,null,null,null,false,false,null,false,true,false,false,false,false]

            bool trieResult = false;

            Trie trie = new Trie();
            {
                trie.Insert("at");
                trie.Insert("and");
                trie.Insert("an");
                trie.Insert("add");
                trieResult = trie.Search1("a");
                trieResult = trie.Search1(".at");
                trie.Insert("bat");
                trieResult = trie.Search1(".at");
                trieResult = trie.Search1("an.");
                trieResult = trie.Search1("a.d.");
                trieResult = trie.Search1("b.");
                trieResult = trie.Search1("a.d");
                trieResult = trie.Search1(".");


                
            }


            var orangesRottingArray = new int[][]
            {
                new int[]{2,1,1},
                new int[]{1,1,0},
                new int[]{0,1,1},

            };
            var orangeRes = OrangesRotting(orangesRottingArray);


           

            Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
            TreeNode root = null;
            AddNewNode(ref root, 3);
            AddNewNode(ref root, 9);
            AddNewNode(ref root, 20);
            AddNewNode(ref root, 1);
            AddNewNode(ref root, 45);
            AddNewNode(ref root, 15);
            AddNewNode(ref root, 7);

            var isBalance = IsBalanced(root);
            var rob2 = Rob2(new int[] { 1, 2, 3, 2, 4, 6, 7 });
            var rob = Rob(new int[] { 2, 7, 9, 3, 1 });

            var isHappy = IsHappy(19);
            var countPrime = CountPrimes(10);

            var coolTime = MaxProfitWithCool(new int[] { 1, 2, 3, 0, 2 });

            var maxWith2Trans = MyMaxProfit2Tr(new int[] { 3, 3, 5, 0, 0, 3, 1, 4 });

            var cutTrees = new List<IList<int>>
            {
                new List<int>{54581641,64080174,24346381,69107959},
                new List<int>{86374198,61363882,68783324,79706116},
                new List<int>{668150,92178815,89819108,94701471},
                new List<int>{83920491,22724204,46281641,47531096 },
                new List<int>{89078499,18904913,25462145,60813308 },


            };
            var cutTree = CutOffTree(cutTrees);

            var topkFreguent = TopKFrequent(new string[] { "i", "love", "leetcode", "i", "love", "coding" }, 2);
            var linkedListRoot = new ListNode(1);
            
            foreach (var item in new int[]  { 2, 3,4 })
            {
                AddNodes(linkedListRoot, item);
            }

            SplitListToParts(linkedListRoot, 5);
          

           var verticalTraversal= VerticalTraversal(root);

            var partition1 = PartitionLabels1("ababcbacadefegdehijhklij");
            var partition = PartitionLabels("ababcbacadefegdehijhklij");
            var arrivalTime = new int[] { 900, 940, 950, 1100, 1500, 1800 };
            var departureTime = new int[] { 910, 1200, 1120, 1130, 1900, 2000 };

            var platForm = FindPlatform(arrivalTime, departureTime, arrivalTime.Length);

           
            var maxprwithCoolTime = MaxProfitWithCoolTime(new int[] { 1, 2, 3, 0, 2 });

            var maxpr = MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });

            var topKFrequent = TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2);

            var solveCharArray = new char[][]
            {
                 new char[]{ 'X', 'X', 'X', 'X'},
                 new char[]{ 'X', 'O' ,'O' ,'X' },
                new char[]{ 'X', 'X', 'O' ,'X' },
                new char[]{ 'X', 'O','X', 'X' }
            };

            Solve(solveCharArray);


            var treasureIslandArray2 = new char[][]
         {
                new char[]{'S', 'O', 'O', 'S', 'S' },
                new char[] {'D', 'O', 'D', 'O', 'D' },
                new char[]{'O', 'O', 'O', 'O', 'X' },
                new char[]{'X', 'D', 'D', 'O', 'O' },
                new char[] {'X', 'D', 'D', 'D', 'O' }


         };

            var treasureIsland2 = TreasureIsland2(treasureIslandArray2);

            var chardi = new char[][]
           {
                new char[]  {'1','1','0','0','0' },
                new char[]  {'1','1','0','0','0' },
                new char[]  {'0','0','1','0','0' },
                new char[]  {'0','0','0','1','1' },

           };

            var numberIsland = NumIslands(chardi);

            var treasureIslandArray = new char[][]
           {
                new char[]  {'o','o','o','o' },
                new char[]  {'D','o','D','o' },
                new char[]  {'x','o','o','o' },
                new char[]  {'o','D','D','0', },

           };

            var treasureIsland = TreasureIsland(treasureIslandArray);

            var mincostconnectRopes = MinCostToConnectRopes(new int[] { 1, 2, 5, 10, 35, 89 });

            var targetFound = OptimalUtilization(new List<List<int>>
            {
                new List<int> {1,8 },
                new List<int>{2,15},
                new List<int>{3,9},

            }, new List<List<int>>
            {
                new List<int>{1,8},
                new List<int>{2,11},
                new List<int>{3,12},
            }, 20);


            // a = [[1, 8], [2, 15], [3, 9]]
            // b = [[1, 8], [2, 11], [3, 12]]

            var logs = new string[] { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };

            ReorderLogFiles(logs);

            var generatedNumber = GenerateNumbers(3);

            var quotes = new string[] {
                                        "Elmo is the hottest of the season! Elmo will be on every kid's wishlist!",
                                        "The new Elmo dolls are super high quality",
                                        "Expect the Elsa dolls to be very popular this year, Elsa!",
                                        "Elsa and Elmo are the toys I'll be buying for my kids, Elsa is good",
                                        "For parents of older kids, look into buying them a drone",
                                        "Warcraft is slowly rising in popularity ahead of the holiday season"
                                        };

            var popularToys = NPopularToys(6, 2, new string[] { "elmo", "elsa", "legos", "drone", "tablet", "warcraft" }, 6, quotes);



            var twoDi = new int[,]
              {
                    {0,1,1,0,1 },
                    {0,1,0,1,0 },
                    {0,1,0,0,1 },
                    {0,1,0,0,0 }
              };

            var minhourCode = MinHours(4, 5, twoDi);

            var reverseString = ReverseWords("the sky is blue");

            WordsInVertical("HEY HOWDY");
            /*HH
             *EO 
             *YW
             * 
             * YDWOH YEH
             * 
             * */
            var largestNumber = LargestNumber(new int[] { 3, 30, 34, 5, 9 });

            var suggestedWords = SuggestedProducts1(new string[] { "mobile", "mouse", "moneypot", "monitor", "mousepad" }, "mouse");
            NextLargerElement(new int[] { 1, 3, 2, 4 });


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
            var criticalNodes = GetCriticalNodes(links, numLinks1, numRouters1);


            var possible = new List<string> { "storage", "battery", "hover", "alex", "waterproof", "solar" };
            var r45 = new List<string> { "i am sharath battery", "manikanda alex", "bharath battery", "jda alex", "waterproof good" };
            var popular = popularNFeatures(6, 2, possible, 7, r45);
          
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


        public static string MostCommonWord(string paragraph, string[] banned)
        {

            return System.Text.RegularExpressions.Regex.Replace(paragraph, @"[^0-9A-Za-z]+", " ")
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).GroupBy(x => x, StringComparer.InvariantCultureIgnoreCase)
                .OrderByDescending(x => x.Count())
                .Where(x => banned.Contains(x.Key, StringComparer.InvariantCultureIgnoreCase) == false)
                .Select(x => x.Key.ToLower()).FirstOrDefault();


        }
        public static int[][] IntervalIntersection(int[][] A, int[][] B)
        {

            if (A.Length == 0 || B.Length == 0) return default(int[][]);

            int i = 0, j = 0;
            var ans = new List<int[]>();
            while (i < A.Length && j < B.Length)
            {
                var startMax = Math.Max(A[i][0], B[i][0]);
                var endMin = Math.Min(A[i][1], B[i][1]);

                if (endMin >= startMax)
                {
                    ans.Add(new int[] { startMax, endMin });

                }

                if (A[i][1] == endMin) i++;
                if (B[i][1] == endMin) j++;


            }

            return ans.ToArray();

        }
        public static int[][] Merge(int[][] intervals)
        {
            if (intervals.Length <= 1) return intervals;

            Array.Sort(intervals, (s1, s2) => s1[0].CompareTo(s2[0]));

           var result = new List<int[]>();

            var newInterval = intervals[0];

            result.Add(newInterval);

            foreach(var interval in intervals)
            {
                if (interval[0] <= newInterval[1])
                {
                    newInterval[1] = Math.Max(interval[1], newInterval[1]);

                }
                else
                {
                    newInterval = interval;
                    result.Add(newInterval);
                }

            }
           

            return result.ToArray();

        }

        public static int OrangesRotting(int[][] grid)
        {

            int rows = grid.Length;
            int columns = grid[0].Length;

            var q = new List<int[]>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        q.Add(new int[] { i, j });
                    }
                }
            }

           
            var dirs = new List<int[]>() { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };
            int count = 0;
            while (true)
            {
                var result = new List<int[]>();
                foreach (var item in q)
                {
                    foreach (var dir in dirs)
                    {
                        var i = item[0] + dir[0];
                        var j = item[1] + dir[1];

                        if (i >= 0 && i < rows && j >= 0 && j < columns && grid[i][j] == 1)
                        {
                            grid[i][j] = 2;
                           
                            result.Add(new int[] { i, j });

                        }
                    }
                   
                }
               
                q = result;
                if (q.Any() == false) break;
                count += 1;
            }

            return count;
        }
        public static int Rob2(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            return Math.Max(Rob(nums, 0, nums.Length - 2), Rob(nums, 1, nums.Length - 1));
        }
        public static int Rob(int[] num, int lo, int hi)
        {
            int include = 0, exclude = 0;
            for (int j = lo; j <= hi; j++)
            {
                int i = include, e = exclude;
                include = e + num[j];
                exclude = Math.Max(e, i);
            }
            return Math.Max(include, exclude);
        }

        public static int Rob(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2) return Math.Max(nums[0], nums[1]);

            var db = new int[nums.Length];
            db[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                var item = i - 2 >= 0 ? db[i - 2] : 0;
                db[i] = Math.Max(nums[i] + item, db[i - 1]);
            }
            return db[nums.Length - 1];
        }
        public static void AddNodes(ListNode root, int val)
        {
            if (root == null)
            {
                root = new ListNode(val);
                return;
            }

            var temp = root;

            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = new ListNode(val);

        }

        public int CalPoints(string[] ops)
        {
            var stack = new Stack<int>();

            foreach(var op in ops)
            {
                if (op.Equals("+"))
                {
                    int top = stack.Pop();
                    int newtop = top + stack.Peek();
                    stack.Push(top);
                    stack.Push(newtop);
                }
                else if (op.Equals("C"))
                {
                    stack.Pop();
                }
                else if (op.Equals("D"))
                {
                    stack.Push(2 * stack.Peek());
                }
                else
                {
                    stack.Push(int.Parse(op));
                }
            }
            return stack.Sum();
        }


        public static IList<string> TopKFrequent(string[] words, int k)
        {

            return words.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenBy(x => x.Key).Take(k).Select(x => x.Key).ToList();

        }
        public static ListNode[] SplitListToParts(ListNode root, int k)
        {

            var cur = root;
            var count = 0;
            while (cur != null)
            {
                cur = cur.next;
                count++;
            }

            int size = count / k;
            int rem = count % k;
            cur = root;
            var ans = new ListNode[k];

            for (int i = 0; i < k; ++i)
            {
                var head = cur;
                for (int j = 0; j < size + (i < rem ? 1 : 0) - 1; ++j)
                {

                    if (cur != null)
                    {
                        cur = cur.next;
                    }
                }

                if (cur != null)
                {
                    var prev = cur;
                    cur = cur.next;
                    prev.next = null;
                }
                ans[i] = head;

            }
            return ans;

        }
        public static List<Location> locations = new List<Location>();
        public static IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            if (root == null) return null;

            DFS(root, 0, 0);
            locations.Sort();
            var ans = new List<IList<int>>();

           foreach(var item in locations.GroupBy(x=>x.x))
            {
                ans.Add(item.Select(x => x.val).ToList());

            }
            return ans;
        }

        private static void DFS(TreeNode node, int x, int y)
        {
            if (node != null)
            {
                locations.Add(new Location(x, y, node.val));
                DFS(node.left, x - 1, y + 1);
                DFS(node.right, x + 1, y + 1);

            }
        }


        public class Location:IComparable<Location>
        {
            public int x;
            public int y;
            public int val;
            public Location(int x, int y, int val)
            {
                this.x = x;
                this.y = y;
                this.val = val;
            }

            public int CompareTo(Location other)
            {
                if (x != other.x)
                {
                   return x.CompareTo(other.x);
                }
                else if(y!=other.y)
                {
                    return x.CompareTo(other.y);
                }
                else
                {
                    return val.CompareTo(other.val);
                }
            }
        }

        public static List<int> PartitionLabels1(string S)
        {
            var last = new int[26];
            for (int i = 0; i < S.Length; i++)
            {
                last[S[i] - 'a'] = i;
            }
            var ans = new List<int>();

            int j = 0;
            int anchor = 0;

            for (int i = 0; i < S.Length; i++)
            {
                j = Math.Max(j, last[S[i] - 'a']);

                if (i == j)
                {
                    ans.Add(i - anchor + 1);
                    anchor = i + 1;
                }
            }
            return ans;
        }
        public static IList<int> PartitionLabels(string S)
        {
            if (string.IsNullOrEmpty(S)) return default(List<int>);

            var list = new List<Part>();
           
            for (int i = 0; i < S.Length; i++)
            {
                var lastIndex = S.LastIndexOf(S[i]);
                var subString = S.Substring(i, (lastIndex + 1) - i);

                if(list.Any() && list.Any(x=>x.Msg.Contains(S[i])))
                {
                    var findItem = list.Where(x => x.Msg.Contains(S[i])).FirstOrDefault();
                    findItem.Msg = findItem.Msg + subString;
                }
                else
                {
                    list.Add(new Part() { Msg=subString});
                }
                i = lastIndex;
               
            }

            var result = new List<int>();
            
            foreach(var item in list)
            {
                var count = item.Msg.Count();
                if (count > 1)
                {
                    result.Add(count);
                   
                }
                else
                {

                    var lastItem = result.Last();
                    lastItem++;
                }
                   
            }
            return result;
        }

        public class Part
        {
            public string Msg { get; set; }
        }

        public static int CutOffTree(IList<IList<int>> forest)
        {
            if (forest[0][0] == 0) return -1;

            int rows = forest.Count();

            int columns = forest[0].Count();

            var q = new List<int[]>();

            var dirs = new List<int[]>()
            {
                        new int[] {1, 0},
                        new int[] {-1, 0},
                        new int[] {0, 1},
                        new int[] {0, -1}
            };

            q.Add(new int[] { 0, 0 });

            forest[0][0] = 1;
            int count = 0;
            while(true)
            {
                var result = new List<int[]>();

                foreach(var item in q)
                {
                    foreach (var dir in dirs)
                    {

                        var i = item[0] + dir[0];
                        var j = item[1] + dir[1];

                        if (i >= 0 && i < rows && j < columns && j >= 0 && forest[i][j] > 1)
                        {
                            forest[i][j] = 1;
                            count++;
                            result.Add(new int[] { i, j });
                        }
                    }
                }

                q = result;
                if (q.Any() == false) break;
            }

            return forest.Any(x => x.Any(y => y > 1)) ? -1 : count;

        }
        public int[][] UpdateMatrix(int[][] matrix)
        {
            int rows = matrix.GetLength(0);

            int columns = matrix[0].GetLength(0);

            bool[,] visited = new bool[rows, columns];

            var q = new List<int[]>();

            var dirs = new List<int[]>()
                    {
                        new int[] {1, 0},
                        new int[] {-1, 0},
                        new int[] {0, 1},
                        new int[] {0, -1}
                    };

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        q.Add(new int[] { i, j });
                        visited[i, j] = true;
                    }
                }
            }

            while (true)
            {
                var result = new List<int[]>();
                foreach (var item in q)
                {
                    foreach (var dir in dirs)
                    {
                        int i = item[0] + dir[0];
                        int j = item[1] + dir[1];

                        if (i < 0 || i >= rows || j < 0 || j >= columns || visited[i, j])
                        {
                            continue;
                        }
                        matrix[i][j] = matrix[item[0]][item[1]] + 1;
                        visited[i, j] = true;
                        result.Add(new int[] { i, j });
                    }
                }
                q = result;

                if (q.Any() == false) break;
            }

            return matrix;
        }
    
    public static List<List<int>> OptimalUtilization(List<List<int>> a, List<List<int>> b, int target)
        {
            if (a.Any() == false || b.Any() == false) return new List<List<int>>();

            var dict = new Dictionary<int, List<List<int>>>();

            foreach (var itemA in a)
            {
                foreach (var itemB in b)
                {
                    var sum = itemA[1] + itemB[1];
                    if (sum <= target)
                    {
                        if (dict.ContainsKey(sum))
                        {
                            dict[sum].Add(new List<int> { itemA[0], itemB[0] });
                        }
                        else
                        {
                            dict.Add(sum, new List<List<int>>() { new List<int> { itemA[0], itemB[0] } });
                        }
                    }
                }
            }

           if(dict.Any())
            {
                return dict.OrderByDescending(x => x.Key).Select(x => x.Value).FirstOrDefault();
            }
            return new List<List<int>>();
           
        }
      
    public static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Any() == false) return null;
            var result = new List<int>();
            foreach(var list in lists)
            {
                var temp = list;
                while(temp != null)
                {
                    result.Add(temp.val);
                    temp = temp.next;

                } 
            }

            if (result.Any())
            {
                result.Sort();
                var listNode = new ListNode(result[0]);
                var curr = listNode;
                for (int i = 1; i < result.Count; i++)
                {

                    curr.next = new ListNode(result[i]);
                    curr = curr.next;

                }

                return listNode;
            }
            return null;
           

        }
        public static IList<int> TopKFrequent(int[] nums, int k)
        {
            if (nums.Any() == false) return default(List<int>);

            var dict = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }
            return dict.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToList();

           // return nums.GroupBy(x => x).OrderByDescending(x => x.Count()).Take(k).Select(x => x.Key).ToList(); 

        }
        public static void Solve(char[][] board)
        {
            if (board == null || board.Length == 0) return; 
            int rows = board.Length;
            int columns = board[0].Length;
     
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (board[i][j] == 'O')
                    {

                        DFSForSurrend(board, rows, columns, i, j);
                    }
                }
            }
        }

        private static void DFSForSurrend(char[][] grid, int m, int n, int i, int j)
        {
            if (i < 0 || i >= m || j < 0 || j >= n || grid[i][j] == 'X') return;
            grid[i][j] = 'X';
            DFSForSurrend(grid, m, n, i + 1, j);
            DFSForSurrend(grid, m, n, i - 1, j);
            DFSForSurrend(grid, m, n, i, j + 1);
            DFSForSurrend(grid, m, n, i, j - 1);
        }

        public static int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0) return 0;
            int rows = grid.Length;
            int columns = grid[0].Length;
            int res = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (grid[i][j] == '1')
                    {


                        DFS(grid, rows, columns, i, j);
                        res += 1;
                    }
                }
            }

            return res;
           
        }
        public string ReverseWords1(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;

            return string.Join("",s.Trim().Split(" ".ToArray(),StringSplitOptions.RemoveEmptyEntries).Reverse());

           



        }
        private static void DFS(char[][] grid, int m, int n, int i, int j)
        {
            if (i < 0 || i >= m || j < 0 || j >= n || grid[i][j] == '0') return;
            grid[i][j] = '0';
            DFS(grid, m, n, i + 1, j);
            DFS(grid, m, n, i - 1, j);
            DFS(grid, m, n, i, j + 1);
            DFS(grid, m, n, i, j - 1);
        }

        public static int MinHours(int rows, int columns, int[,] grid)
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
            var directions = new List<int[]> { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };
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

        public static bool FindWords(char[][] board, string word)
        {
            int rows = board.Length;
            int columns = board[0].Length;

            var q = new List<int[]>();


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        q.Add(new int[] { i, j });
                    }
                }

            }

            var dirs = new List<int[]>() { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };
            int k = 1;
            var ans = new List<string>();


            while (true)
            {
                var result = new List<int[]>();

                foreach (var item in q)
                {
                    foreach (var dir in dirs)
                    {
                        var i = item[0] + dir[0];
                        var j = item[1] + dir[1];

                        if (i >= 0 && i < rows && j >= 0 && j < columns && k < word.Length && board[i][j] == word[k])
                        {
                           
                            result.Add(new int[] { i, j });

                        }
                    }
                }
              
                q = result;
                if (q.Any() == false) break;
                if (k == word.Length)
                {
                    return true;
                }
                k++;
            }

            return k == word.Length;
        }

        public bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (Exist(board, i, j, word, 0))
                        return true;
                }
            return false;
        }
        private bool Exist(char[][] board, int i, int j, string word, int ind)
        {
            if (ind == word.Length) return true;
            if (i > board.Length - 1 || i < 0 || j < 0 || j > board[0].Length - 1 || board[i][j] != word[ind])
                return false;
            board[i][j] = '*';
            var result = Exist(board, i - 1, j, word, ind + 1) ||
                                Exist(board, i, j - 1, word, ind + 1) ||
                                Exist(board, i, j + 1, word, ind + 1) ||
                                Exist(board, i + 1, j, word, ind + 1);

            board[i][j] = word[ind];
            return result;
        }

        public static int TreasureIsland2(char[][] island)
        {
            int rows = island.Length;
            int columns = island[0].Length;

            var q = new List<int[]>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (island[i][j] == 'S')
                    {
                        q.Add(new int[] { i, j });
                        island[i][j] = 'D';
                    }
                }
            }
           
            var dirs = new List<int[]> { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };

            while (true)
            {
                var result = new List<int[]>();
                foreach (var item in q)
                {
                    foreach (var dir in dirs)
                    {
                        var i = item[0] + dir[0];
                        var j = item[1] + dir[1];

                        if (0 <= i && i < columns && 0 <= j && j < rows)
                        {
                            if (island[i][j] == 'X')
                            {
                                time += 1;
                                return time;
                            }
                            if (island[i][j] != 'D')
                            {
                                island[i][j] = 'D';
                                result.Add(new int[] { i, j });
                            }
                        }

                    }

                }

                q = result;
                if (q.Any() == false) return time;
                time += 1;

            }
        }
        public static int TreasureIsland(char[][] island)
        {
            int rows = island.Length;
            int columns = island[0].Length;

            var q = new List<int[]>
            {
                new int[] { 0, 0 }
            };
            var time = 1;
            island[0][0] = 'D';

            var dirs = new List<int[]> { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };

            while (true)
            {
                var result = new List<int[]>();
                foreach (var item in q)
                {
                    foreach (var dir in dirs)
                    {
                        var m = item[0] + dir[0];
                        var n = item[1] + dir[1];

                        if (0 <= m && m < columns && 0 <= n && n < rows)
                        {
                            if (island[m][n] == 'x')
                            {
                                time += 1;
                                return time;
                            }
                            if (island[m][n] != 'D')
                            {
                                island[m][n] = 'D';
                                result.Add(new int[] { m, n });
                            }
                        }

                    }
                  
                  
                }

                q = result;
                if (q.Any() == false) return time;
                time += 1;

            }
        }

        public static int MinCostToConnectRopes(int[] ropes)
        {

            var listItems = new List<int>(ropes);
            int i = 0;
            int sum = 0;
            while (i <= ropes.Length / 2)
            {
                var r = listItems.OrderBy(x => x).Skip(i * 2).Take(2).Sum();
                listItems.Add(r);
                sum += r;
                i += 1;
            }


            return sum;
           
        }


        public static string[] ReorderLogFiles(string[] logs)
        {

            if (logs.Length == 0) return logs;

            return logs.Where(x => !x.Split(' ')[1].All(char.IsDigit))
                       .OrderBy(x => x.Substring(x.IndexOf(" ") + 1))
                       .ThenBy(x=>x.Substring(0,x.IndexOf(" ")))
                       .Union(logs.Where(x => x.Split(' ')[1].All(char.IsDigit))).ToArray();


        }
    
    public static List<int> GenerateNumbers(int numRows)
        {
            ++numRows;
            var db = new int[numRows, numRows];
            var item = new List<int>();
            var result = new List<List<int>>();
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (i == j || j == 0)
                    {
                        db[i, j] = 1;
                        item.Add(1);
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

            return result[numRows - 1];
        }



        public static List<string> NPopularToys(int numToys, int topToys, string[] toys, int numQuotes, string[] quotes)
        {

            var dictionary = new Dictionary<string, int>();

            foreach (var quote in quotes)
            {
                foreach (var toy in toys)
                {

                    if (quote.ToLower().Contains(toy.ToLower()))
                    {

                        if (dictionary.ContainsKey(toy))
                        {
                            dictionary[toy]++;
                        }
                        else
                        {
                            dictionary.Add(toy, 1);
                        }
                    }
                }
            }

            return dictionary.OrderByDescending(x => x.Value).Take(topToys).Select(x => x.Key).ToList();
        }



       

        public static string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;
           return string.Join(" ", s.Trim().Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).Reverse());


        }
        public static List<string> WordsInVertical(string str)
        {
            var splitStr = str.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            int maxLength = 0;
            foreach (var item in splitStr)
            {
                if (item.Length > maxLength)
                {
                    maxLength = item.Length;

                }
            }

            var result = new List<string>();
            var strItem = string.Empty;
            for (int i = 0; i < maxLength; i++)
            {
                for (int j = 0; j < splitStr.Length; j++)
                {

                    strItem += splitStr[j].Length > i ? splitStr[j].Substring(i, 1) : " ";
                }
                result.Add(strItem);
                strItem = string.Empty;
            }
            return result;
        }
        public static string LargestNumber(int[] nums)
        {
            if (nums.Any() == false) return string.Empty;

            if (nums.Count() == 1) return nums[0].ToString();

            var stringArray = nums.Select(x => x.ToString()).ToArray();

            Array.Sort(stringArray, (string s1, string s2) =>
            {
                var str1 = s1 + s2;
                var str2 = s2 + s1;
                return str2.CompareTo(str1);
            });

            if(stringArray[0].Equals("0"))
            {
                return "0";
            }
            return string.Join("", stringArray);
        }
        public static IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            if (string.IsNullOrEmpty(searchWord) || products.Any() == false) return new List<IList<string>>();

            var dictionary = new Dictionary<string, SortedSet<string>>();

            foreach (var item in products)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    var subStr = item.Substring(0, i + 1);

                    if (dictionary.ContainsKey(subStr) == false)
                    {
                        dictionary.Add(subStr, new SortedSet<string>());
                    }
                    dictionary[subStr].Add(item);
                }
            }

            var result = new List<IList<string>>();
            for (int i = 0; i < searchWord.Length; i++)
            {
                var subStr = searchWord.Substring(0, i + 1);

                if (dictionary.ContainsKey(subStr))
                {
                    result.Add(dictionary[subStr].Take(3).ToList());
                }
                else
                {
                    result.Add(new List<string>());
                }
            }

            return result;
        }

        public static IList<IList<string>> SuggestedProducts1(string[] products, string searchWord)
        {
            if (string.IsNullOrEmpty(searchWord) || products.Any() == false) return new List<IList<string>>();

            Array.Sort(products);

            var result = new List<IList<string>>();
            for (int i = 0; i < searchWord.Length; i++)
            {
                var subStr = searchWord.Substring(0, i + 1);

                if(products.Any(x=>x.Contains(subStr)))
                {
                    result.Add(products.Where(x => x.Contains(subStr)).Take(3).ToList());
                   
                }
                else
                {
                    result.Add(new List<string>());
                }
            }

            return result;
        }

        private static void NextLargerElement(int[] nums)
        {
            bool flag = false;
            for (int i = 0; i < nums.Length; i++)
            {
                flag = false;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] > nums[i])
                    {
                        flag = true;
                        Console.WriteLine(nums[j]);
                        break;
                    }
                }
                if (flag == false) Console.WriteLine("-1");
            }
        }
        static int time = 0;
        private static List<int> GetCriticalNodes(int[][] links, int numLinks, int numRouters)
        {
            time = 0;
            var dictionary = new Dictionary<int, List<int>>();

            for (int i = 0; i < numRouters; i++)
            {
                dictionary.Add(i, new List<int>());
            }
            foreach (var link in links)
            {
                dictionary[link[0]].Add(link[1]);
                dictionary[link[1]].Add(link[0]);
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
                    DFS(dictionary, low, ids, parent, i, set);
            }
            return set;
        }
        public static void DFS(Dictionary<int, List<int>> dictionary, int[] low, int[] ids, int[] parent, int cur, List<int> res)
        {
            int children = 0;

            ids[cur] = low[cur] = ++time;

            foreach (int nei in dictionary[cur])
            {
                if (ids[nei] == -1)
                {
                    children++;
                    parent[nei] = cur;
                    DFS(dictionary, low, ids, parent, nei, res);
                    low[cur] = Math.Min(low[cur], low[nei]);
                    if ((parent[cur] == -1 && children > 1) || (parent[cur] != -1 && low[nei] >= ids[cur]))
                        res.Add(cur);
                }
                else if (nei != parent[cur])
                    low[cur] = Math.Min(low[cur], ids[nei]);
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
        public string[] ReorderLogFiles1(string[] logs)
        {


            var onlyLetters = logs.Where(x => !x.Split(' ')[1].All(char.IsDigit)).OrderBy(x => x.Substring(x.IndexOf(' ') + 1)).ThenBy(x => x.Substring(0, x.IndexOf(' ')));
            var onlyDigit = logs.Where(x => x.Split(' ')[1].All(char.IsDigit));

            return onlyLetters.Union(onlyDigit).ToArray();
                




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
        public static int FindPlatform(int[] arr,
                        int[] dep, int n)
        {

            var arrival = new List<Train>();
            var departure = new List<Train>();
            for (int i = 0; i < n; i++)
            {
                arrival.Add(new Train() { Name = "Arrival", Time = arr[i] });
                departure.Add(new Train() { Name = "Departure", Time = dep[i] });
            }

            arrival = arrival.Union(departure).ToList();
            arrival.Sort();

            int platFormCount = 0;
            int max = 0;
            foreach(var item in arrival)
            {
                if(item.Name=="Arrival")
                {
                    platFormCount += 1;
                }
                else
                {
                    platFormCount -= 1;
                }
                max = Math.Max(max, platFormCount);
            }
            return max; 
        }
        public class Train: IComparable<Train>
        {
            public string Name { get; set; }
            public int Time { get; set; }

            public int CompareTo(Train other)
            {
                return Time.CompareTo(other.Time);
            }
        }
        public static int MaxProfitWithCool(int[] prices)
        {
            if (prices.Length <= 1) return 0;

            int prev_rest = 0;
            int prev_sell = 0;
            int prev_buy = -prices[0];

            foreach (var p in prices)
            {
                var buy = Math.Max(prev_rest - p, prev_buy);
                var sell = Math.Max(prev_buy + p, prev_sell);
                prev_buy = buy;
                prev_rest = prev_sell;
                prev_sell = sell;
            }

            return Math.Max(prev_rest, prev_sell);

        }

        public static int MyMaxProfit2Tr(int[] prices)
        {
            int buyOne = int.MaxValue;
            int ProfitOne = 0;               // Profit gained after selling 1st share.
            int buyTwo = int.MaxValue;
            int ProfitTwo = 0;               // Profit gained after selling 2nd share.
            foreach (var p in prices)
            {
                buyOne = Math.Min(buyOne, p);
                ProfitOne = Math.Max(ProfitOne, p - buyOne);
                buyTwo = Math.Min(buyTwo, p - ProfitOne);     // If I made $100 profit in 1st trans'. Then the 2nd Stock(maybe $300) I buy is actually $300 - $100 = $200 for me. 
                ProfitTwo = Math.Max(ProfitTwo, p - buyTwo);   // And finally The maximum profit I make with the 2nd trans' is my actuall profit with 2 transaction. 
            }
            return ProfitTwo;
        }
       
        
        public static int MaxProfitWithCoolTime(int[] prices)
        {
            if (prices.Length <= 1) return 0;

            int s0 = 0;
            int s1 = -prices[0];
            int s2 = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                s1 = Math.Max(s1, s0 - prices[i]);
                s0 = Math.Max(s0, s2);
                s2 = s1 + prices[i];
            }
            return Math.Max(s2, s0);
        }

        public static int MaxProfit(int[] prices)
        {
            var max = 0;
            var min = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (min > prices[i])
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

        public static bool IsBalanced(TreeNode root)
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
        public static int BalancedTree(TreeNode root)
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

        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode prev = null;
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            prev.next = null;

            var firstHalf = SortList(head);
            var secondHalf = SortList(slow);
            return MergeLinkedList(firstHalf, secondHalf);
        }

        ListNode MergeLinkedList(ListNode firstHalf, ListNode secondHalf)
        {
            var resNode = new ListNode(0);
            var mergeNode = resNode;

            while (firstHalf != null && secondHalf != null)
            {
                if (firstHalf.val < secondHalf.val)
                {
                    mergeNode.next = firstHalf;
                    firstHalf = firstHalf.next;
                }
                else
                {
                    mergeNode.next = secondHalf;
                    secondHalf = secondHalf.next;
                }
                mergeNode = mergeNode.next;
            }

            if (firstHalf != null)
                mergeNode.next = firstHalf;

            if (secondHalf != null)
                mergeNode.next = secondHalf;

            return resNode.next;
        }

    
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                    nums1[k--] = nums1[i--];
                else
                    nums1[k--] = nums2[j--];
            }
            while (j >= 0)
                nums1[k--] = nums2[j--];
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
        public static void Merge1(int[] nums1, int m, int[] nums2, int n)
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
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000},

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
        public static  bool IsHappy(int n)
        {
            if (n == 0) return false;
            if (n == 1) return true;
            var square = 0;
            var list = new List<int>();
            while (n != 0)
            {
                var rem = n % 10;
                square += rem * rem;
                n = n / 10;
                if (n == 0)
                {
                    if (square == 1)
                    {
                        return true;
                    }

                    if (list.Contains(square))
                    {
                        return false;
                    }
                    else
                    {
                        list.Add(square);
                    }
                    n = square;
                    square = 0;
                }

            }
            return true;
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
        public bool isSubtree(TreeNode s, TreeNode t)
        {
            if (s == null) return false;
            if (isSame(s, t)) return true;
            return isSubtree(s.left, t) || isSubtree(s.right, t);
        }

        private bool isSame(TreeNode s, TreeNode t)
        {
            if (s == null && t == null) return true;
            if (s == null || t == null) return false;

            if (s.val != t.val) return false;

            return isSame(s.left, t.left) && isSame(s.right, t.right);
        }
        public TreeNode InvertTree(TreeNode root)
        {

            if (root == null) return null;

            var right = InvertTree(root.right);
            var left = InvertTree(root.left);

            root.left = right;
            root.right = left;

            return root;

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
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }


        public static List<string> FindWordsWithTrie(char[][] board, string[] words)
        {
            var res = new List<string>();
            var trie = new Trie();

            foreach (var word in words)
            {
                trie.Insert(word);
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    DFSFindWord(board, i, j, trie.root, res);
                }
            }
            return res;
        }

        private static void DFSFindWord(char[][] board, int i, int j, Trie.TrieNode root, List<string> res)
        {
            char ch = board[i][j];

            if (ch == '#' || root.children.ContainsKey(ch) == false) return;

            root.children.TryGetValue(ch, out Trie.TrieNode node);

            root = node;

            if (root.word != null)
            {
                res.Add(root.word);
                root.word = null;
            }

            board[i][j] = '#';
            if (i > 0) DFSFindWord(board, i - 1, j, root, res);
            if (j > 0) DFSFindWord(board, i, j - 1, root, res);
            if (i < board.Length - 1) DFSFindWord(board, i + 1, j, root, res);
            if (j < board[0].Length - 1) DFSFindWord(board, i, j + 1, root, res);
            board[i][j] = ch;
        }

        public class Trie
        {
            public TrieNode root;
            public class TrieNode
            {
                public Dictionary<char, TrieNode> children;
                public bool endOfWord;
                public string word;
                public TrieNode()
                {
                    children = new Dictionary<char, TrieNode>();
                    endOfWord = false;
                }
            }
            public Trie()
            {
                root = new TrieNode();
            }
            public void Insert(string word)
            {
                TrieNode current = root;
                for (int i = 0; i < word.Length; i++)
                {
                    char ch = word[i];

                    if (current.children.TryGetValue(ch, out TrieNode node) == false)
                    {
                        node = new TrieNode();
                        current.children.Add(ch, node);
                    }
                    current = node;
                }
                current.endOfWord = true;
                current.word = word;
            }

            public void InsertRecursive(string word)
            {
                InsertRecursive(root, word, 0);
            }

            private void InsertRecursive(TrieNode current, string word, int index)
            {
                if (index == word.Length)
                {
                    current.endOfWord = true;
                    return;
                }

                char ch = word[index];
                if (current.children.TryGetValue(ch, out TrieNode node) == false)
                {
                    node = new TrieNode();
                    current.children.Add(ch, node);
                }
                InsertRecursive(node, word, index + 1);
            }
            public bool Search(string word)
            {
                TrieNode current = root;
                for (int i = 0; i < word.Length; i++)
                {
                    char ch = word[i];

                    if (current.children.TryGetValue(ch, out TrieNode node) == false)
                    {
                        return false;
                    }
                    current = node;
                }
                return current.endOfWord;
            }

            public bool Search1(string word)
            {
                TrieNode current = root;
                for (int i = 0; i < word.Length; i++)
                {
                    char ch = word[i];
                    TrieNode node = null;
                    if (ch == '.')
                    {
                       node = current.children.Select(x => x.Value).FirstOrDefault();
                    }
                    else if (current.children.TryGetValue(ch, out node) == false)
                    {
                        return false;
                    }
                    current = node;
                }
                return current.endOfWord;
            }

            public bool Search2(string word)
            {
                return Match(word.ToCharArray(), 0, root);
            }

            private bool Match(char[] chs, int k, TrieNode node)
            {
                if (k == chs.Length) return node.endOfWord;

                if (chs[k] == '.')
                {
                    foreach (var item in node.children)
                    {
                        if (item.Value != null)
                        {
                            if (Match(chs, k + 1, item.Value))
                            {
                                return true;
                            }
                        }
                    }
                }
                else
                {
                    return node.children.TryGetValue(chs[k], out TrieNode value) && Match(chs, k + 1, value);

                }
                return false;
            }


            public bool SearchRecursive(string word)
            {
                return SearchRecursive(root, word, 0);
            }

            private bool SearchRecursive(TrieNode current, string word, int index)
            {
                if (index == word.Length)
                {

                    return current.endOfWord;
                }

                char ch = word[index];
             
                if (current.children.TryGetValue(ch, out TrieNode node) == false)
                {
                    return false;
                }
                return SearchRecursive(node, word, index + 1);
            }

            public void Delete(string word)
            {
                Delete(root, word, 0);
            }
            private bool Delete(TrieNode current, string word, int index)
            {
                if (index == word.Length)
                {
                    if (!current.endOfWord)
                    {
                        return false;
                    }
                    current.endOfWord = false;
                    return current.children.Count() == 0;
                }

                char ch = word[index];
           
                if (current.children.TryGetValue(ch, out TrieNode node) == false)
                {
                    return false;
                }

                bool shouldDeleteCurrentNode = Delete(node, word, index + 1);

                if (shouldDeleteCurrentNode)
                {
                    current.children.Remove(ch);
                    return current.children.Count() == 0;
                }
                return false;
            }
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
