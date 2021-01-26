using System;
using System.Collections.Generic;
using System.Text;

namespace B2_Bridge
{
    public class JPGImage : AbsImage
    {
        public override void ParseFile(string fileName)
        {
            // 模拟解析JPG文件并获得一个像素矩阵对象m
            Matrix m = new Matrix();
            imageImpl.DoPaint(m);
            Console.WriteLine("{0} : 格式为JPG", fileName);
        }
    }

    public class BMPImage : AbsImage
    {
        public override void ParseFile(string fileName)
        {
            // 模拟解析BMP文件并获得一个像素矩阵对象m
            Matrix m = new Matrix();
            imageImpl.DoPaint(m);
            Console.WriteLine("{0} : 格式为BMP", fileName);
        }
    }

    public class GIFImage : AbsImage
    {
        public override void ParseFile(string fileName)
        {
            // 模拟解析BMP文件并获得一个像素矩阵对象m
            Matrix m = new Matrix();
            imageImpl.DoPaint(m);
            Console.WriteLine("{0} : 格式为GIF", fileName);
        }
    }
}
