using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Operations.Leet_Code.Patterns
{
    // What is it: Using pointers at different poisitions, We can efficiently compare elements & make decisions
    //             without relying on nested loops.

    // When to use: Generally applied to linear data structures (array, strings, linked list)

    // Benefits: Turn array related problems from O(n^2) to O(n)

    // Types:
    // 1. Converging Pointers: - Pointers start at opposite ends of a DS & move inward towards each other.
    //                         - Pointers adjust thier positions based on comparisons.
    // 2. Parallel Pointers: - Pointers start at the same position and move in the same direction.
    //                       - Those pointers serve different but complementary roles, 1st pointer is used to explore
    //                          and find new info. Meanwhile, the 2nd pointer used to track progress or maintain constraints.
    //                       - Sliding window is a variation of this technique.
    // 3. Trigger Based-Pointers: - The 1st pointer moves independently until it finds an element that meets a certian condition.
    //                            - After this, we start traversing using the 2nd pointer to find info related to what the 1st pointer found.

    internal class TwoPointers
    {

    }
}
