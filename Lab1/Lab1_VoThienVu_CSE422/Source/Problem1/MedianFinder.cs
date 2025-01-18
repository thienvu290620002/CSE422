using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_VoThienVu_CSE422.Source.Problem1
{
    public class MedianFinder
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // Đảm bảo nums1 là mảng nhỏ hơn
            if (nums1.Length > nums2.Length)
            {
                var temp = nums1;
                nums1 = nums2;
                nums2 = temp;
            }

            int m = nums1.Length;
            int n = nums2.Length;
            int totalLen = m + n;

            int imin = 0, imax = m, halfLen = (totalLen + 1) / 2;

            while (imin <= imax)
            {
                int i = (imin + imax) / 2; // Chỉ số phân hoạch cho nums1
                int j = halfLen - i; // Chỉ số phân hoạch cho nums2

                if (i < m && nums2[j - 1] > nums1[i])
                {
                    // i quá nhỏ, cần tăng imin
                    imin = i + 1;
                }
                else if (i > 0 && nums1[i - 1] > nums2[j])
                {
                    // i quá lớn, cần giảm imax
                    imax = i - 1;
                }
                else
                {
                    // i đã được phân hoạch đúng
                    int maxLeft = 0;
                    if (i == 0) maxLeft = nums2[j - 1]; // Không có phần tử nào ở bên trái trong nums1
                    else if (j == 0) maxLeft = nums1[i - 1]; // Không có phần tử nào ở bên trái trong nums2
                    else maxLeft = Math.Max(nums1[i - 1], nums2[j - 1]); // Giá trị lớn nhất bên trái

                    if (totalLen % 2 == 1)
                    {
                        return maxLeft; // Trả về phần tử ở giữa nếu tổng độ dài là lẻ
                    }

                    int minRight = 0;
                    if (i == m) minRight = nums2[j]; // Không có phần tử nào ở bên phải trong nums1
                    else if (j == n) minRight = nums1[i]; // Không có phần tử nào ở bên phải trong nums2
                    else minRight = Math.Min(nums1[i], nums2[j]); // Giá trị nhỏ nhất bên phải

                    return (maxLeft + minRight) / 2.0; // Tính trung bình nếu tổng độ dài là chẵn
                }
            }

            throw new ArgumentException("Input arrays are not sorted.");
        }
    }
}