﻿/*******************************************************}
{                                                       }
{               HCView V1.1  作者：荆通                 }
{                                                       }
{      本代码遵循BSD协议，你可以加入QQ群 649023932      }
{            来获取更多的技术交流 2018-5-4              }
{                                                       }
{        文档ExpressItem(分数类公式)对象实现单元        }
{                                                       }
{*******************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HC.View
{
    class HCExpressItem : HCFractionItem
    {
        public HCExpressItem(HCCustomData AOwnerData, string ALeftText, string ATopText, string ARightText, string ABottomText) : base(AOwnerData, ATopText, ABottomText)
        {

        }
    }
}
