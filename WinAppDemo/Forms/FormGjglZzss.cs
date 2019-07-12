﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppDemo.Db.Base;
using WinAppDemo.Db.Model;
using System.Data.SQLite;
using WinAppDemo.Controls;

namespace WinAppDemo.Forms
{
    public partial class FormGjglZzss : Form
    {
        //private List<TreeNodeTypes> Types;

        public FormGjglZzss()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQLiteConnection conn = null;
            ////获取数据文件的路径
            //string dbPath = "Data Source =D:\\手机取证工作路径设置\\案件20190707093739\\HONORV2020190701094546\\AppData\\Weixin\\ca9529dc14475dbcc7e8553e77ad7d0b\\midwxtrans.db";// + Program.m_mainform.g_workPath+"\\AppData\\Weixin\\ca9529dc14475dbcc7e8553e77ad7d0b" + "\\midwxtrans.db";
            ////创建数据库实例，指定文件位置
            //conn = new SQLiteConnection(dbPath);              
            //conn.Open();


            //conn.Close();
            ////添加根节点
            //TreeNode nodeAJ = new TreeNode();
            //nodeAJ.Text = Program.m_mainform.g_ajName + @"（已删除\未删除\总共）";
            //UcZjzs uc = new UcZjzs();

            //uc.treeView2.Nodes.Add(nodeAJ);


            //TreeNode nodeZJ = new TreeNode();

            //nodeZJ.Text = Program.m_mainform.g_zjName + @"（ \ \ ）";
            //nodeAJ.Nodes.Add(nodeZJ);           //添加证据结点

            //TreeNode nodeBase = new TreeNode("基础信息");
            //nodeZJ.Nodes.Add(nodeBase);

            //int BaseNum = Program.m_mainform.checkBaseList.Count;
            //for (int i = 0; i < BaseNum; i++)
            //{
            //    TreeNode node = new TreeNode(Program.m_mainform.checkBaseList[i]);
            //    nodeBase.Nodes.Add(node);
            //}

            //int FileNum = Program.m_mainform.checkFileList.Count;
            //if (FileNum > 0)
            //{
            //    TreeNode nodeFile = new TreeNode("文件信息");
            //    nodeZJ.Nodes.Add(nodeFile);
            //    for (int i = 0; i < FileNum; i++)
            //    {
            //        TreeNode node = new TreeNode(Program.m_mainform.checkFileList[i]);
            //        nodeFile.Nodes.Add(node);
            //    }
            //}

            //int AppNum = Program.m_mainform.checkAppList.Count;
            //if (AppNum > 0)
            //{
            //    TreeNode nodeApp = new TreeNode("APP列表");
            //    nodeZJ.Nodes.Add(nodeApp);
            //    for (int i = 0; i < AppNum; i++)
            //    {
            //        TreeNode node = new TreeNode(Program.m_mainform.checkAppList[i]);
            //        nodeApp.Nodes.Add(node);
            //        if (node.Text == "微信")
            //        {
            //            TreeNode node1 = new TreeNode("账号1");
            //            node.Nodes.Add(node1);
            //            TreeNode node11 = new TreeNode("账号信息");
            //            node1.Nodes.Add(node11);
            //            TreeNode node12 = new TreeNode("通讯录");
            //            node1.Nodes.Add(node12);
            //            TreeNode node121 = new TreeNode("好友");
            //            node12.Nodes.Add(node121);
            //            TreeNode node122 = new TreeNode("公众号");
            //            node12.Nodes.Add(node122);
            //            TreeNode node123 = new TreeNode("群聊");
            //            node12.Nodes.Add(node123);
            //            TreeNode node124 = new TreeNode("应用程序");
            //            node12.Nodes.Add(node124);
            //            TreeNode node125 = new TreeNode("其他");
            //            node12.Nodes.Add(node125);


            //            TreeNode node13 = new TreeNode("聊天记录");
            //            node1.Nodes.Add(node13);
            //            TreeNode node131 = new TreeNode("好友");
            //            node13.Nodes.Add(node131);
            //            TreeNode node132 = new TreeNode("群聊");
            //            node13.Nodes.Add(node132);
            //            TreeNode node133 = new TreeNode("公众号");
            //            node13.Nodes.Add(node133);

            //            TreeNode node14 = new TreeNode("朋友圈");
            //            node1.Nodes.Add(node14);
            //            TreeNode node141 = new TreeNode("本人的朋友圈");
            //            node14.Nodes.Add(node141);
            //            TreeNode node142 = new TreeNode("好友的朋友圈");
            //            node14.Nodes.Add(node142);
            //        }
            //    }
            //}

            //  treeView2.ExpandAll();

            string keyword=textBox1.Text;



            Program.m_mainform.AddNewGjalZs();
            this.Close();

        }

        private void FormGjglZzss_Load(object sender, EventArgs e)
        {
    
            //添加根节点
            TreeNode nodeAJ = new TreeNode();
            nodeAJ.Text = Program.m_mainform.g_ajName+ @"（已删除\未删除\总共）";
            treeView1.Nodes.Add(nodeAJ);

            TreeNode nodeZJ = new TreeNode();
            nodeZJ.Text = Program.m_mainform.g_zjName + @"（ \ \ ）";
            nodeAJ.Nodes.Add(nodeZJ);           //添加证据结点
            
            TreeNode nodeBase = new TreeNode("基础信息");
            nodeZJ.Nodes.Add(nodeBase);

            int BaseNum = Program.m_mainform.checkBaseList.Count;
            for (int i = 0; i < BaseNum; i++)
            {
                TreeNode node = new TreeNode(Program.m_mainform.checkBaseList[i]);
                nodeBase.Nodes.Add(node);
            }

            int FileNum = Program.m_mainform.checkFileList.Count;
            if (FileNum > 0)
            {
                TreeNode nodeFile = new TreeNode("文件信息");
                nodeZJ.Nodes.Add(nodeFile);
                for (int i = 0; i < FileNum; i++)
                {
                    TreeNode node = new TreeNode(Program.m_mainform.checkFileList[i]);
                    nodeFile.Nodes.Add(node);
                }
            }

            int AppNum = Program.m_mainform.checkAppList.Count;
            if(AppNum>0)
            {
                TreeNode nodeApp = new TreeNode("APP列表");
                nodeZJ.Nodes.Add(nodeApp);
                for (int i = 0; i < AppNum; i++)
                {
                    TreeNode node = new TreeNode(Program.m_mainform.checkAppList[i]);                    
                    nodeApp.Nodes.Add(node);
                    if(node.Text=="微信")
                    {
                        TreeNode node1 = new TreeNode("账号1");
                        node.Nodes.Add(node1);
                        TreeNode node11 = new TreeNode("账号信息");                        
                        node1.Nodes.Add(node11);
                        TreeNode node12 = new TreeNode("通讯录");
                        node1.Nodes.Add(node12);
                            TreeNode node121 = new TreeNode("好友");
                            node12.Nodes.Add(node121);
                            TreeNode node122 = new TreeNode("公众号");
                            node12.Nodes.Add(node122);
                            TreeNode node123 = new TreeNode("群聊"); 
                            node12.Nodes.Add(node123);
                            TreeNode node124 = new TreeNode("应用程序"); 
                            node12.Nodes.Add(node124);
                            TreeNode node125 = new TreeNode("其他");
                            node12.Nodes.Add(node125);


                        TreeNode node13 = new TreeNode("聊天记录");
                        node1.Nodes.Add(node13);
                            TreeNode node131 = new TreeNode("好友");
                            node13.Nodes.Add(node131);
                            TreeNode node132 = new TreeNode("群聊");
                            node13.Nodes.Add(node132);
                            TreeNode node133 = new TreeNode("公众号");
                            node13.Nodes.Add(node133);

                        TreeNode node14 = new TreeNode("朋友圈");
                        node1.Nodes.Add(node14);
                            TreeNode node141 = new TreeNode("本人的朋友圈");
                            node14.Nodes.Add(node141);
                            TreeNode node142 = new TreeNode("好友的朋友圈");
                            node14.Nodes.Add(node142);
                    }
                }
            }

            //treeView1.ExpandAll();
            


            //Types = new List<TreeNodeTypes>()
            //{
            //    new TreeNodeTypes() {Id = 1, Name = @"证据（47\13433\13480）", Value = "1", ParentId = 0},
            //    new TreeNodeTypes() {Id = 2, Name = @"手机信息（47\13433\13480）", Value = "2", ParentId = 1},
            //    new TreeNodeTypes() {Id = 3, Name = @"即时通讯（47\13433\13480）", Value = "3", ParentId = 1},
            //    new TreeNodeTypes() {Id = 4, Name = @"基本信息（47\13433\13480）", Value = "4", ParentId = 2},
            //    new TreeNodeTypes() {Id = 5, Name = @"通讯录（47\13433\13480）", Value = "5", ParentId = 2},
            //    new TreeNodeTypes() {Id = 6, Name = @"微信（47\13433\13480）", Value = "6", ParentId = 3},
            //};

            //using (SqliteDbContext context = new SqliteDbContext())
            //{//ca9529dc14475dbcc7e8553e77ad7d0b
            // //   context.Database.Connection.ConnectionString = "Data Source="+ "D:\\手机取证工作路径设置\\案件20190707093739\\HONORV2020190701094546\\AppData\\Weixin\\a12788cdac6ba28270d03cc2df9a0122" + "\\midwxtrans.db";
            //    context.WxAccounts.ToList().ForEach(acc =>
            //    {
            //        int index = Types.Count + 1;
            //        Types.Add(new TreeNodeTypes() { Id = index, Name = acc.Sign, ParentId = 6, Value = acc.WxId });
            //        Types.Add(new TreeNodeTypes() { Id = index + 1, Name = "好友", ParentId = index, Value = "好友" });
            //        Types.Add(new TreeNodeTypes() { Id = index + 2, Name = "公众号", ParentId = index, Value = "公众号" });
            //        Types.Add(new TreeNodeTypes() { Id = index + 3, Name = "聊天记录", ParentId = index, Value = "聊天记录" });
            //        Types.Add(new TreeNodeTypes() { Id = index + 4, Name = "应用程序", ParentId = index, Value = "应用程序" });
            //        Types.Add(new TreeNodeTypes() { Id = index + 5, Name = "朋友圈", ParentId = index, Value = "朋友圈" });
            //        Types.Add(new TreeNodeTypes() { Id = index + 6, Name = "新朋友", ParentId = index, Value = "新朋友" });
            //    });
            //}


            //var topNode = new TreeNode();
            //topNode.Name = "0";
            //topNode.Text = Program.m_mainform.g_ajName + @"（已删除\未删除\总共）"; // @"案件（已删除\未删除\总共）";
            //treeView1.Nodes.Add(topNode);
            //Bind(topNode, Types, 0);

            //treeView1.ExpandAll();
        }
        //private void Bind(TreeNode parNode, List<TreeNodeTypes> list, int nodeId)
        //{
        //    var childList = list.FindAll(t => t.ParentId == nodeId).OrderBy(t => t.Id);

        //    foreach (var urlTypese in childList)
        //    {
        //        var node = new TreeNode();
        //        node.Name = urlTypese.Id.ToString();
        //        node.Text = urlTypese.Name;
        //        node.Tag = urlTypese.Value;
        //        parNode.Nodes.Add(node);
        //        Bind(node, list, urlTypese.Id);
        //    }
        //}

        private void ufn_CheckChildren(TreeNode node)
        {
            if (node.Nodes.Count > 0)
            {
                foreach (TreeNode n in node.Nodes)
                {
                    n.Checked = node.Checked;
                    this.ufn_CheckChildren(n);
                }
            }
        }
        
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            this.ufn_CheckChildren(e.Node);
        }
    }

    //public class TreeNodeTypes
    //{
    //    public int Id { get; set; }

    //    public string Name { get; set; }

    //    public string Value { get; set; }

    //    public int ParentId { get; set; }
    //}
}
