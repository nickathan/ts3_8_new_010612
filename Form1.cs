using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
 using System.Data.OleDb;
using System.Linq;
//using System.Collections.Generic;
namespace ts3
{







     //public  int CurrentRowIndex{get;set;}

     /// <summary>
     /// Summary description for Form1.
     /// </summary>
     public class TableDisplay : System.Windows.Forms.Form
     {

        int ai = 0;
          int cnt19 = 0;
          int cnt1919 = 0;
          int cnt191919 = 0;
          private object threadLock = new object();
          int gm = 0;
          //OleDbConnection  oleDbConnection10;
          // DataTable dt;
          string last_used_query = "";
          OleDbDataAdapter adapter;
          public DataSet dataSet4 = new DataSet();
          public DataTable dt1 = new DataTable();
          public int ghost_search = 0;
          public DataSet dataSet8;
          public OleDbConnection oleDbConnection4, oleDbConnection10;
          OleDbCommand command;
          OleDbDataAdapter oleDbDataAdapter2;
          public int conflag2 = 0;
          public int conflag10 = 0;
          public List<draw1> draws = new List<draw1>();
          public object draws1;
          SortedList sl = new SortedList();
          int f900 = 0, f901 = 1, f902 = 0, f903 = 0, f904 = 0, f905 = 0;
          int flag900 = 0, flag901 = 1, flag902 = 0, flag903 = 0, flag904 = 0, flag905 = 0;
          int f88 = 0, f89 = 1, f90 = 0, f38 = 0, f39 = 0;
          int adhi = 0;
          int flag108 = 0, flag109 = 0, flag208 = 0;
          //int[] j1,j2,j3,j4,j5,j6,j7,j8,j9,j10,j11,j12,j13,j14,j15,j16,j17,j18,j19,j20;
          //int[] j1997,j1998,j1999,j2000,j2001,j2002,j2003,j2004,j2005;
          int f1228 = 0, f1229 = 0, f1230 = 0, f1231 = 0, f1232 = 0;
          int flag1 = 0, flag2 = 0, flag3 = 0, flag4 = 0, flag5 = 0, rem1 = 0, rem2 = 0, rem3 = 0, rem4 = 0, rem5 = 0, flag110 = 0, flag111 = 0, flag112 = 0;
          public int f312 = 5;
          public int f30 = 1, f131 = 1, f132 = 0, f133 = 0, f134 = 0;
          public int MaxRows = 0, inc = 0;
          int C22 = 0;
          // int f38 = 0;
          int f112 = 0;
          int ret_flag = 1;
          int flag6 = 0, flag8 = 0, flag9 = 0, flag11 = 0, flag12 = 0, flag7 = 0, flag10 = 0;
          int rflag2 = 0;
          int c21 = 0;
          int scan_mode_flag = 0;
          int counter = 0;
          public Random winrandom3from15 = new Random();
          public Random winrandom = new Random();
          public Random winrandom15from45 = new Random();
          public int[] data_mine_flag = { 5, 4, 3, 2, 1 };
          public int[] data_mine_flag2 = { 1, 5, 10, 10, 5 };
          public int[] tot_dm_flag = new int[31];
          public int nbm_mode_flag = 0;
          public int nbm_count_flag = 0;
          public int i22 = 0;
          int f128 = 1, f130 = 1;

          public int[,] nbm_mode_6_6 = new int[362, 6] {{1,0,0,0,0,0 },{0,1,0,0,0,0},{0,0,1,0,0,0},{0,0,0,1,0,0},{0,0,0,0,1,0},{0,0,0,0,0,1}  //1(0-5)=6
                                                       
                                                         
                                                       
                                                        
                                                        
                                                         
                                                        ,{2,0,0,0,0,0 },{0,2,0,0,0,0},{0,0,2,0,0,0},{0,0,0,2,0,0},{0,0,0,0,2,0},{0,0,0,0,0,2} //2(6-26)=21
                                                        ,{1,1,0,0,0,0 },{1,0,1,0,0,0},{1,0,0,1,0,0},{1,0,0,0,1,0},{1,0,0,0,0,1}  //2
                                                        ,{0,1,1,0,0,0 },{0,1,0,1,0,0},{0,1,0,0,1,0},{0,1,0,0,0,1}
                                                          ,{0,0,1,1,0,0 },{0,0,1,0,1,0},{0,0,1,0,0,1}
                                                         ,{0,0,0,1,1,0 },{0,0,0,1,0,1}
                                                         , {0,0,0,0,1,1 }

                                                         ,{3,0,0,0,0,0 },{0,3,0,0,0,0},{0,0,3,0,0,0},{0,0,0,3,0,0},{0,0,0,0,3,0},{0,0,0,0,0,3}  //3(27-81)=55
                                                         ,{2,1,0,0,0,0 },{2,0,1,0,0,0},{2,0,0,1,0,0},{2,0,0,0,1,0},{2,0,0,0,0,1}  //3
                                                        ,{0,2,1,0,0,0 },{0,2,0,1,0,0},{0,2,0,0,1,0},{0,2,0,0,0,1}
                                                          ,{0,0,2,1,0,0 },{0,0,2,0,1,0},{0,0,2,0,0,1}
                                                         ,{0,0,0,2,1,0 },{0,0,0,2,0,1}
                                                         , {0,0,0,0,2,1 }
                                                             ,{1,2,0,0,0,0 },{1,0,2,0,0,0},{1,0,0,2,0,0},{1,0,0,0,2,0},{1,0,0,0,0,2}
                                                        ,{0,1,2,0,0,0 },{0,1,0,2,0,0},{0,1,0,0,2,0},{0,1,0,0,0,2}
                                                          ,{0,0,1,2,0,0 },{0,0,1,0,2,0},{0,0,1,0,0,2}
                                                         ,{0,0,0,1,2,0 },{0,0,0,1,0,2}
                                                         , {0,0,0,0,1,2 }
                                                            ,{1,1,1,0,0,0 },{1,1,0,1,0,0},{1,1,0,0,1,0},{1,1,0,0,0,1}
                                                             ,{1,0,1,0,1,0},{1,0,1,0,0,1},{1,0,0,1,0,1}
                                                          ,{0,1,1,1,0,0 },{0,1,1,0,1,0},{0,1,1,0,0,1}
                                                        ,{0,1,0,1,0,1}
                                                          ,{0,0,1,1,1,0 },{0,0,1,1,0,1}
                                                         ,{0,0,0,1,1,1}
                                                            ,{1,0,1,1,0,0},{1,0,0,1,1,0},{1,0,0,0,1,1}
                                                        ,{0,1,0,1,1,0},{0,1,0,0,1,1}

                                                           ,{4,0,0,0,0,0 },{0,4,0,0,0,0},{0,0,4,0,0,0},{0,0,0,4,0,0},{0,0,0,0,4,0},{0,0,0,0,0,4}  //4 (82-173)=92 
                                                        ,{2,2,0,0,0,0 },{2,0,2,0,0,0},{2,0,0,2,0,0},{2,0,0,0,2,0},{2,0,0,0,0,2}  //4
                                                        ,{0,2,2,0,0,0 },{0,2,0,2,0,0},{0,2,0,0,2,0},{0,2,0,0,0,2}
                                                          ,{0,0,2,2,0,0 },{0,0,2,0,2,0},{0,0,2,0,0,2}
                                                         ,{0,0,0,2,2,0 },{0,0,0,2,0,2}
                                                         , {0,0,0,0,2,2 }
                                                             ,{2,1,1,0,0,0 },{2,0,1,1,0,0},{2,0,0,1,1,0},{2,0,0,0,1,1}
                                                        ,{0,2,1,1,0,0 },{0,2,0,1,1,0},{0,2,0,0,1,1}
                                                          ,{0,0,2,1,1,0 },{0,0,2,0,1,1}
                                                         ,{0,0,0,2,1,1 }

                                                            ,{1,1,2,0,0,0 },{1,1,0,2,0,0},{1,1,0,0,2,0},{1,1,0,0,0,2}
                                                        ,{0,1,1,2,0,0 },{0,1,1,0,2,0},{0,1,1,0,0,2}
                                                          ,{0,0,1,1,2,0 },{0,0,1,1,0,2}
                                                         ,{0,0,0,1,1,2}
                                                            ,{1,0,1,2,0,0},{1,0,0,1,2,0},{1,0,0,0,1,2}
                                                        ,{0,1,0,1,2,0},{0,1,0,0,1,2}
                                                          ,{0,0,0,1,1,2}
                                                            ,{1,2,1,0,0,0 },{1,2,0,1,0,0},{1,2,0,0,1,0},{1,2,0,0,0,1}
                                                        ,{0,1,2,1,0,0 },{0,1,2,0,1,0},{0,1,2,0,0,1}
                                                          ,{0,0,1,2,1,0 },{0,0,1,2,0,1}
                                                         ,{0,0,0,1,2,1}
                                                            ,{1,0,2,1,0,0},{1,0,0,2,1,0},{1,0,0,0,2,1}
                                                        ,{0,1,0,2,1,0},{0,1,0,0,2,1}
                                                          ,{0,0,0,1,2,1}
                                                            ,{2,1,1,0,0,0 },{2,1,0,1,0,0},{2,1,0,0,1,0},{2,1,0,0,0,1}
                                                        ,{0,2,1,1,0,0 },{0,2,1,0,1,0},{0,2,1,0,0,1}
                                                          ,{0,0,2,1,1,0 },{0,0,2,1,0,1}
                                                         ,{0,0,0,2,1,1}
                                                            ,{2,0,1,1,0,0},{2,0,0,1,1,0},{2,0,0,0,1,1}
                                                        ,{0,2,0,1,1,0},{0,2,0,0,1,1}
                                                          ,{0,0,0,2,1,1}
                                                          ,{1,1,0,1,1,0 },{1,1,0,0,1,1}
                                                          ,{1,0,1,1,1,0 }
                                                          ,{1,0,1,0,1,1 },{1,0,0,1,1,1},{1,1,1,0,0,1}
                                                            ,{1,1,1,1,0,0 },{1,1,1,0,1,0},{1,1,1,0,0,1}
                                                        ,{0,1,1,1,1,0 },{0,1,1,1,0,1}
                                                          ,{0,0,1,1,1,1 }

                                                            ,{5,0,0,0,0,0 },{0,5,0,0,0,0},{0,0,5,0,0,0},{0,0,0,5,0,0},{0,0,0,0,5,0},{0,0,0,0,0,5}  //5( 174-362 )=189
                                                          ,{3,2,0,0,0,0 },{3,0,2,0,0,0},{3,0,0,2,0,0},{3,0,0,0,2,0},{3,0,0,0,0,2}  //5
                                                        ,{0,3,2,0,0,0 },{0,3,0,2,0,0},{0,3,0,0,2,0},{0,3,0,0,0,2}
                                                          ,{0,0,3,2,0,0 },{0,0,3,0,2,0},{0,0,3,0,0,2}
                                                         ,{0,0,0,3,2,0 },{0,0,0,3,0,2}
                                                         , {0,0,0,0,3,2 }
                                                             ,{2,3,0,0,0,0 },{2,0,3,0,0,0},{2,0,0,3,0,0},{2,0,0,0,3,0},{2,0,0,0,0,3}
                                                        ,{0,2,3,0,0,0 },{0,2,0,3,0,0},{0,2,0,0,3,0},{0,2,0,0,0,3}
                                                          ,{0,0,2,3,0,0 },{0,0,2,0,3,0},{0,0,2,0,0,3}
                                                         ,{0,0,0,2,3,0 },{0,0,0,2,0,3}
                                                         , {0,0,0,0,2,3 }
                                                            ,{1,1,3,0,0,0 },{1,1,0,3,0,0},{1,1,0,0,3,0},{1,1,0,0,0,3}
                                                        ,{0,1,1,3,0,0 },{0,1,1,0,3,0},{0,1,1,0,0,3}
                                                          ,{0,0,1,1,3,0 },{0,0,1,1,0,3}
                                                         ,{0,0,0,1,1,3}
                                                            ,{1,0,1,3,0,0},{1,0,0,1,3,0},{1,0,0,0,1,3}
                                                        ,{0,1,0,1,3,0},{0,1,0,0,1,3}
                                                          ,{0,0,0,1,1,3}
                                                            ,{1,3,1,0,0,0 },{1,3,0,1,0,0},{1,3,0,0,1,0},{1,3,0,0,0,1}
                                                        ,{0,1,3,1,0,0 },{0,1,3,0,1,0},{0,1,3,0,0,1}
                                                          ,{0,0,1,3,1,0 },{0,0,1,3,0,1}
                                                         ,{0,0,0,1,3,1}
                                                            ,{1,0,3,1,0,0},{1,0,0,3,1,0},{1,0,0,0,3,1}
                                                        ,{0,1,0,3,1,0},{0,1,0,0,3,1}
                                                          ,{0,0,0,1,3,1}
                                                            ,{3,1,1,0,0,0 },{3,1,0,1,0,0},{3,1,0,0,1,0},{3,1,0,0,0,1}
                                                        ,{0,3,1,1,0,0 },{0,3,1,0,1,0},{0,3,1,0,0,1}
                                                          ,{0,0,3,1,1,0 },{0,0,3,1,0,1}
                                                         ,{0,0,0,3,1,1}
                                                            ,{3,0,1,1,0,0},{3,0,0,1,1,0},{3,0,0,0,1,1}
                                                        ,{0,3,0,1,1,0},{0,3,0,0,1,1}
                                                          ,{0,0,0,3,1,1}

                                                           ,{1,1,2,1,0,0 },{1,1,0,2,1,0},{1,1,0,0,2,1}
                                                           ,{1,1,1,2,0,0 },{1,1,0,1,2,0},{1,1,0,0,1,2}
                                                        ,{0,1,1,2,1,0 },{0,1,1,0,2,1}
                                                        ,{0,1,1,1,2,0 },{0,1,1,0,1,2}
                                                          ,{0,0,1,1,2,1 },{0,0,1,1,1,2}

                                                            ,{1,0,1,2,1,0},{1,0,0,1,2,1}
                                                             ,{1,0,1,1,2,0},{1,0,0,1,1,2}

                                                        ,{0,1,0,1,2,1},{0,1,0,1,1,2}

                                                             ,{1,2,1,1,0,0},{1,2,1,0,1,0},{1,2,1,0,0,1}
                                                             , {1,1,2,0,1,0},{1,1,2,0,0,1}

                                                        ,{0,1,2,1,1,0 },{0,1,2,0,1,1}
                                                        ,{0,1,1,2,1,0 },{0,1,1,0,2,1}
                                                          ,{0,0,1,2,1,1 },{0,0,1,1,2,1}

                                                            ,{1,0,2,1,1,0}
                                                         ,{0,1,0,2,1,1}
                                                          ,{0,0,2,1,1,1}  ,{0,0,1,1,1,2}

                                                        ,{2,1,1,1,0,0 },{2,1,1,0,1,0},{2,1,1,0,0,1}


                                                          ,{0,2,1,1,1,0 },{0,2,1,1,0,1}



                                                        ,{2,1,0,1,1,0},{2,1,0,0,1,1}

                                                        ,{1,2,0,1,1,0},{1,2,0,0,1,1}

                                                         ,{1,2,2,0,0,0 },{1,2,0,2,0,0},{1,2,0,0,2,0},{1,2,0,0,0,2}
                                                             ,{1,0,2,0,2,0},{1,0,2,0,0,2},{1,0,0,2,0,2}
                                                          ,{0,1,2,2,0,0 },{0,1,2,0,2,0},{0,1,2,0,0,2}
                                                        ,{0,1,0,2,0,2}
                                                          ,{0,0,1,2,2,0 },{0,0,1,2,0,2}
                                                         ,{0,0,0,2,2,2}
                                                            ,{1,0,2,2,0,0},{1,0,0,2,2,0},{1,0,0,0,2,2}
                                                        ,{0,1,0,2,2,0},{0,1,0,0,2,2}


                                                         ,{2,1,2,0,0,0 },{2,1,0,2,0,0},{2,1,0,0,2,0},{2,1,0,0,0,2}
                                                             ,{2,0,1,0,2,0},{2,0,1,0,0,2},{2,0,0,1,0,2}
                                                          ,{0,2,1,2,0,0 },{0,2,1,0,2,0},{0,2,1,0,0,2}
                                                        ,{0,2,0,1,0,2}
                                                          ,{0,0,2,1,2,0 },{0,0,2,1,0,2}
                                                         ,{0,0,0,2,1,2}
                                                            ,{2,0,1,2,0,0},{2,0,0,1,2,0},{2,0,0,0,1,2}
                                                        ,{0,2,0,1,2,0},{0,2,0,0,1,2}


                                                         ,{2,2,1,0,0,0 },{2,2,0,1,0,0},{2,2,0,0,1,0},{2,2,0,0,0,1}
                                                             ,{2,0,2,0,1,0},{2,0,2,0,0,1},{2,0,0,2,0,1}
                                                          ,{0,2,2,1,0,0 },{0,2,2,0,1,0},{0,2,2,0,0,1}
                                                        ,{0,2,0,2,0,1}
                                                          ,{0,0,2,2,1,0 },{0,0,2,2,0,1}
                                                         ,{0,0,0,2,2,1}
                                                            ,{2,0,2,1,0,0},{2,0,0,2,1,0},{2,0,0,0,2,1}
                                                        ,{0,2,0,2,1,0},{0,2,0,0,2,1}



                                                            ,{1,1,1,1,1,0 } ,{1,0,1,1,1,1 } ,{1,1,0,1,1,1 } ,{1,1,1,0,1,1 },{1,1,1,1,0,1 }
                                                        ,{0,1,1,1,1,1 }   };













          //  public void sm_auto_scan();

          public int[] tot_dm_flag2 = new int[31];
          public int dm_flag = 0, endflag1 = 0, f226 = 0, f228 = 0, f230 = 0;
          public int[,] data_mine_temp1 = new int[1, 5];
          public int[,] data_mine_temp = new int[1, 5];
          public int[,] data_mine1 = new int[31, 5] { { 0, 1, 2, 3, 4 }, { 0, 1, 2, 3, 0 }, { 0, 2, 3, 4, 0 }, { 1, 2, 3, 4, 0 }, { 0, 1, 3, 4, 0 }, { 0, 1, 2, 4, 0 }, { 1, 2, 3, 0, 0 }, { 2, 3, 4, 0, 0 }, { 0, 2, 3, 0, 0 }, { 0, 3, 4, 0, 0 }, { 1, 2, 4, 0, 0 }, { 0, 2, 4, 0, 0 }, { 0, 1, 4, 0, 0 }, { 0, 1, 3, 0, 0 }, { 1, 3, 4, 0, 0 }, { 0, 1, 2, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 2, 0, 0, 0 }, { 0, 3, 0, 0, 0, }, { 0, 4, 0, 0, 0 }, { 1, 2, 0, 0, 0 }, { 1, 3, 0, 0, 0 }, { 1, 4, 0, 0, 0 }, { 2, 3, 0, 0, 0 }, { 2, 4, 0, 0, 0 }, { 3, 4, 0, 0, 0 }, { 0, 0, 0, 0, 0, }, { 1, 0, 0, 0, 0 }, { 2, 0, 0, 0, 0 }, { 3, 0, 0, 0, 0 }, { 4, 0, 0, 0, 0 } };
          public int[] data_mine_count = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
          public int[,] data_mine11 = new int[31, 5];
          public int[,] data_mine12 = new int[31, 5];
          public int[,] data_mine2 = new int[200000, 80];//   support  combination   %, integer     seperation   space_real  positions required 63 as follows :  0=index  of draw in database  then  each 0f the 31 pairs  the position of combination in the specific draw+the number of occurances  in  the whole history.0,1_32,2_33,.....31_62.The rest of position will  be used in future  time.
          public int[,] data_mine6 = new int[100000, 80];//   confidense   combination   %,integer     seperation   space
          public int[] deltemp15 = new int[15];
          public int[] del15 = new int[15];
          public int[] del2temp15 = new int[15];
          public int[,] win5temp = new int[10000, 5];
          public int[,] winpat = new int[10000, 100];
          public int[,] win5 = new int[300, 5];
          public int[] numpar15 = new int[15];
          public int[] numtemp15 = new int[15];
          public int[] num15 = new int[15];
          public int[] winnum15 = new int[15];
          public int[] winnumfinal15 = new int[15];
          public int[] win5temp1 = new int[46];//for   prediction method  stores the count of  win5 array numbers  1-45
          public int[] startAuto15 = { 1, 5, 6, 9, 13, 14, 16, 20, 32, 33, 35, 37, 39, 40, 44 };
          public int[] startAuto151 = { 1, 5, 6, 9, 13, 14, 16, 20, 32, 33, 35, 37, 39, 40, 44 };
          public int[] startAuto16 = new int[15];
          public int[,] tempStartAuto15 = new int[10000, 15];
          public int[,] history_7 = new int[10000, 15];
          public int[,] h3 = new int[100000, 20];
          public int[,] h13 = new int[100000, 15];
          public int[] startAutotemp15 = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43 };
          public int[] current15;
          public int[] maxAutotemp15new = { 1, 5, 6, 9, 13, 14, 16, 20, 32, 33, 35, 37, 39, 40, 44 };
          public int[] maxAutotemp15 = { 6, 13, 20, 27, 34, 41, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
          public int[] maxAutotemp13 = { 4, 7, 11, 13, 15, 22, 25, 26, 28, 29, 31, 34, 37, 40, 43 };
          // public void nbm_mode_adjust();

          public int a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, a0 = 0, a7 = 0, a8 = 0, a9 = 0, a10 = 0, a11 = 0, a12 = 0, a13 = 0, a14 = 0;

          public int win_cnt = 5;
          public int nbm_flag = 0;//enab=1,disable=0
          public int nbm_flag_man = 0;//enab=1,disable=0
          public int nbm_flag_auto = 0;//enab=1,disable=0
          public int nbm_num1_flag = 0;//checked=1,uncheked=0
          public int nbm_num2_flag = 0;//checked=1,uncheked=0
          public int nbm_num3_flag = 0;//checked=1,uncheked=0
          public int nbm_num4_flag = 0;//checked=1,uncheked=0
          public int nbm_num5_flag = 0;//checked=1,uncheked=0
          public int nbm_delta_total = 0;
          public int nbm_num_count = 0;
          public int nbm_num6_flag = 0;//checked=1,uncheked=0
          public int nbm_num7_flag = 0;//checked=1,uncheked=0
          public int[,] ntd_16_array = new int[12, 6];  //total distant  of each  winning  combination  1 unit from  central 6 numbering
          public int[,] ntd_26_array = new int[200, 6];//total distant  of each  winning  combination  2 units from  central  6  numbering
                                                       // public int[,] ntd_36_array = new int[12, 6];
                                                       // public int[,] ntd_46_array = new int[12, 6];
          public int[,] ntd_17_array = new int[14, 7];//total distant  of each  winning  combination  1 unit from  central 7 numbering
          public int[,] ntd_27_array = new int[400, 7];//total distant  of each  winning  combination  2 units from  central 7 numbering
                                                       // public int[,] ntd_37_array = new int[12, 7];
                                                       // public int[,] ntd_47_array = new int[12, 7];





          public int[,] nbm_num_array = new int[15, 2];
          public int nbm4 = 0;
          public int nbm5 = 0;
          public int nbm_loop_count = 1;
          public int dm1 = 0, dm2 = 0;
          public int fl2 = 0;

          public int i1 = 0, i3 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0;
          public int ll1 = 0, ll2 = 0, ll3 = 0, ll4 = 0;

          public int f61 = 0, f62 = 0;
          public int f41 = 0, f42 = 0, f43 = 0, f44 = 0;
          public int f31, f32, f33, f34;

          public int f12 = 0, f14 = 0, f16, f18 = 1, f20, f22 = 0, f23 = 0, f24 = 0;
          public int f5 = 0, f10 = 0, f15 = 1, f21 = 0;


          public int tempf21 = 0, tempif21 = 0, tempif61 = 0, tempf61 = 0;
          public int ri4;
          public int loopflag = 0;
          public int repflag = 0, frep = 0;
          public int n = 0;
          int temp = 0;
          int winflag = 0;
          public int f22temp = 0;
          public int man1 = 0;
          public int endflag = 0, startflag = 0;
          public int repflag2 = 0;
          public int sm1 = 0, sm2 = 0, sm3 = 14, sm4 = 0, sm8 = 7, sm9 = 0;
          public int flag_num = 6;


          //private System.Windows.Forms.MessageBox.Show;
          private System.Windows.Forms.DataGrid dataGrid2;
          private System.Windows.Forms.Button btnSubmit;
          private System.Windows.Forms.TextBox txtQuery;
          public System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
          private System.Windows.Forms.Button btnProcess;
          public System.Data.DataSet dataSet1;
          private System.Data.DataSet dataSet2;
          private System.Windows.Forms.GroupBox groupBox2;
          private System.Data.OleDb.OleDbCommandBuilder cmdBuilder;
          private System.Data.OleDb.OleDbConnection oleDbConnection1;
          private System.Windows.Forms.Button btnJoker;
          private System.Windows.Forms.Button btnNumber;
          private System.Windows.Forms.RadioButton radioBtnDraw;
          public System.Windows.Forms.TextBox txtUserSelect;
          private System.Windows.Forms.RadioButton radioBtnUser;
          private System.Windows.Forms.Label labelSelect;
          private System.Windows.Forms.RichTextBox txtResults;
          private System.Data.OleDb.OleDbCommand oleDbCommand1;
          private System.Data.DataView dataView1;
          private System.Data.OleDb.OleDbConnection oleDbConnection2;
          private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
          private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
          private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
          private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
          private System.Data.OleDb.OleDbConnection oleDbConnection3;
          private BindingSource form2BindingSource;
          private BindingSource draw1BindingSource;
          private Button button1;
          private RadioButton radioButton1;
          private IContainer components;
          private Button button2;
          private RadioButton radioButton4;
          private RadioButton radioButton3;
          private RadioButton radioButton2;
          private GroupBox groupBox4;
          private GroupBox groupBox5;
          private TextBox textBox15;
          private TextBox textBox14;
          private TextBox textBox13;
          private TextBox textBox12;
          private TextBox textBox11;
          private TextBox textBox10;
          private TextBox textBox9;
          private TextBox textBox8;
          private TextBox textBox7;
          private TextBox textBox6;
          private TextBox textBox5;
          private TextBox textBox4;
          private TextBox textBox3;
          private TextBox textBox2;
          private TextBox textBox1;
          private Button button13;
          private GroupBox groupBox6;
          private RadioButton radioButton6;
          private RadioButton radioButton5;
          private TextBox textBox16;
          private Label label9;
          private Label label10;
          private Button button4;
          private Label label11;
          private TextBox textBox17;
          private Label label12;
          private TextBox textBox18;
          private DataSet1 dataSet11;
          private RadioButton radioButton7;
          private RadioButton radioButton8;
          private CheckBox checkBox2;
          private Button Data_mine_support_btn;
          private Button Data_mine_confidence_btn;
          private GroupBox groupBox3;
          private RadioButton radioButton12;
          private RadioButton radioButton11;
          private RadioButton radioButton10;
          private RadioButton radioButton9;
          private GroupBox groupBox7;
          private GroupBox groupBox9;
          private RadioButton radioButton14;
          private RadioButton radioButton13;
          private NumericUpDown numericUpDown10;
          private NumericUpDown numericUpDown9;
          private NumericUpDown numericUpDown8;
          private NumericUpDown numericUpDown7;
          private NumericUpDown numericUpDown6;
          private NumericUpDown numericUpDown5;
          private NumericUpDown numericUpDown4;
          private NumericUpDown numericUpDown3;
          private NumericUpDown numericUpDown2;
          private NumericUpDown numericUpDown1;
          private CheckBox checkBox6;
          private CheckBox checkBox5;
          private CheckBox checkBox4;
          private CheckBox checkBox3;
          private CheckBox checkBox1;
          private Label label13;
          private NumericUpDown numericUpDown11;
          private RadioButton radioButton15;
          private GroupBox groupBox8;
          private NumericUpDown numericUpDown12;
          private Label label14;
          private Label label15;
          private TextBox textBox21;
          private RichTextBox txtResults2;
          private ContextMenuStrip contextMenuStrip1;
          private ContextMenuStrip contextMenuStrip2;
          private ToolStripMenuItem toolStripMenuItem1;
          private ToolStripMenuItem toolStripMenuItem2;
          private ToolStripMenuItem toolStripMenuItem3;
          private ToolStripMenuItem toolStripMenuItem4;
          private ToolStripMenuItem toolStripMenuItem5;
          private ToolStripMenuItem toolStripMenuItem6;
          private CheckBox checkBox8;
          private NumericUpDown numericUpDown16;
          private NumericUpDown numericUpDown15;
          private NumericUpDown numericUpDown14;
          private NumericUpDown numericUpDown13;
          private CheckBox checkBox7;
          private DataGridView dataGridView1;
          private Button button5;
          private Button button6;
          private BindingNavigator bindingNavigator1;
          private ToolStripButton bindingNavigatorAddNewItem;
          private ToolStripLabel bindingNavigatorCountItem;
          private ToolStripButton bindingNavigatorDeleteItem;
          private ToolStripButton bindingNavigatorMoveFirstItem;
          private ToolStripButton bindingNavigatorMovePreviousItem;
          private ToolStripSeparator bindingNavigatorSeparator;
          private ToolStripTextBox bindingNavigatorPositionItem;
          private ToolStripSeparator bindingNavigatorSeparator1;
          private ToolStripButton bindingNavigatorMoveNextItem;
          private ToolStripButton bindingNavigatorMoveLastItem;
          private ToolStripSeparator bindingNavigatorSeparator2;
          private GroupBox groupBox1;
          private CheckBox checkBox9;
          private NumericUpDown numericUpDown17;
          private TextBox textBox19;
          private Label label1;
          private GroupBox groupBox10;
          private CheckBox checkBox10;
          private Button button8;
          private Button button7;
          private Label label2;
          private TextBox textBox20;
          private Label label3;
          private Button button9;
          private OpenFileDialog openFileDialog1;
          private OpenFileDialog openFileDialog2;
          private Label label4;
          public List<ts3.draw1> draw11;
          //  public int add_nums();





          public TableDisplay()
          {
               //
               // Required for Windows Form Designer support
               //this

               //textBox20.Text = "";
               //textBox20.Text = "D:\\JOCKER4.mdb";

               InitializeComponent();
               //oleDbConnection2.DataSource="D:\\JOCKER4.mdb";


               try
               {
                    oleDbDataAdapter1.Fill(dataSet1, "joker1");

                    MessageBox.Show("Connection  with the  Database  " + oleDbConnection2.DataSource.ToString() + " is active !For your info .. this is the Default path database...");
                    conflag2 = 1;
               }

               catch (Exception ex)
               {
                    MessageBox.Show("Can not open connection ! ...No  Database  named  jocker4.mdb  was  found in the default  Directory   D:\\");
               }

               //DataTable    dataTable =dataSet1.Tables[0];
               try
               {
                    dataGridView1.DataSource = dataSet1.Tables[0].DefaultView;


               }
               catch (Exception ex1)
               {
                    MessageBox.Show("Can not open DataSet ! ");
               }


               // DataView  dataview  =dataSet1.Tables[0].DefaultView;
               // dataView1.Sort="date ASC";
               //dataGrid1.DataSource=dataview;
               //dataGrid2.DataSource=dataView1;


               try
               {
                    DataTable dataTable = dataSet1.Tables[0];
                    txtUserSelect.Text = dataTable.Rows.Count.ToString();
                    //dataGrid1.SetDataBinding(dataview,"joker1");


               }
               // Display(dataSet1);
               catch (Exception ex1)
               {
                    MessageBox.Show("Can not open Tables ! ");
               }
               //
               // TODO: Add any constructor code after InitializeComponent call
               //
          }

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          protected override void Dispose(bool disposing)
          {
               if (disposing)
               {
                    if (components != null)
                    {
                         components.Dispose();
                    }
               }
              base.Dispose(disposing);
          }
          // TableDisplay  t1;

          #region Windows Form Designer generated code
          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableDisplay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection3 = new System.Data.OleDb.OleDbConnection();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.btnProcess = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.dataSet2 = new System.Data.DataSet();
            this.btnJoker = new System.Windows.Forms.Button();
            this.btnNumber = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnUser = new System.Windows.Forms.RadioButton();
            this.labelSelect = new System.Windows.Forms.Label();
            this.txtUserSelect = new System.Windows.Forms.TextBox();
            this.radioBtnDraw = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtResults = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.dataView1 = new System.Data.DataView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.button13 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.dataSet11 = new ts3.DataSet1();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Data_mine_support_btn = new System.Windows.Forms.Button();
            this.Data_mine_confidence_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.numericUpDown16 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown15 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.txtResults2 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown17 = new System.Windows.Forms.NumericUpDown();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.draw1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.draw1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid2
            // 
            this.dataGrid2.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dataGrid2.BackColor = System.Drawing.Color.RosyBrown;
            this.dataGrid2.BackgroundColor = System.Drawing.Color.Aqua;
            this.dataGrid2.CaptionBackColor = System.Drawing.Color.White;
            this.dataGrid2.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dataGrid2.CaptionForeColor = System.Drawing.Color.Navy;
            this.dataGrid2.DataMember = "";
            this.dataGrid2.ForeColor = System.Drawing.Color.Black;
            this.dataGrid2.GridLineColor = System.Drawing.Color.Black;
            this.dataGrid2.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid2.HeaderBackColor = System.Drawing.Color.Silver;
            this.dataGrid2.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid2.LinkColor = System.Drawing.Color.Navy;
            this.dataGrid2.Location = new System.Drawing.Point(16, 1466);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.ParentRowsBackColor = System.Drawing.Color.White;
            this.dataGrid2.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid2.SelectionBackColor = System.Drawing.Color.Navy;
            this.dataGrid2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid2.Size = new System.Drawing.Size(1420, 213);
            this.dataGrid2.TabIndex = 6;
            this.dataGrid2.CurrentCellChanged += new System.EventHandler(this.dataGrid2_CurrentCellChanged);
            this.dataGrid2.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid2_Navigate);
            // 
            // txtQuery
            // 
            this.txtQuery.BackColor = System.Drawing.Color.Aqua;
            this.txtQuery.Location = new System.Drawing.Point(1436, 1136);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuery.Size = new System.Drawing.Size(948, 288);
            this.txtQuery.TabIndex = 18;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(24, 1680);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(192, 67);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "SUBMIT  QUERY";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "JOKER1", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("DATE1", "DATE1"),
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("JOKERNUMBER", "JOKERNUMBER"),
                        new System.Data.Common.DataColumnMapping("NUMBER1", "NUMBER1"),
                        new System.Data.Common.DataColumnMapping("NUMBER2", "NUMBER2"),
                        new System.Data.Common.DataColumnMapping("NUMBER3", "NUMBER3"),
                        new System.Data.Common.DataColumnMapping("NUMBER4", "NUMBER4"),
                        new System.Data.Common.DataColumnMapping("NUMBER5", "NUMBER5")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            this.oleDbDataAdapter1.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.oleDbDataAdapter1_RowUpdated_2);
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection2;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Param1", System.Data.OleDb.OleDbType.Variant, 1024, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("ID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("JOKERNUMBER", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JOKERNUMBER", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("JOKERNUMBER1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JOKERNUMBER", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("NUMBER1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("NUMBER11", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("NUMBER2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("NUMBER21", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("NUMBER3", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("NUMBER31", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("NUMBER4", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("NUMBER41", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("NUMBER5", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER5", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("NUMBER51", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER5", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbConnection2
            // 
            this.oleDbConnection2.ConnectionString = resources.GetString("oleDbConnection2.ConnectionString");
            this.oleDbConnection2.InfoMessage += new System.Data.OleDb.OleDbInfoMessageEventHandler(this.oleDbConnection2_InfoMessage);
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `JOKER1` (`DATE1`, `JOKERNUMBER`, `NUMBER1`, `NUMBER2`, `NUMBER3`, `N" +
    "UMBER4`, `NUMBER5`) VALUES (?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection2;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("DATE1", System.Data.OleDb.OleDbType.Variant, 1024, "DATE1"),
            new System.Data.OleDb.OleDbParameter("JOKERNUMBER", System.Data.OleDb.OleDbType.Integer, 0, "JOKERNUMBER"),
            new System.Data.OleDb.OleDbParameter("NUMBER1", System.Data.OleDb.OleDbType.Integer, 0, "NUMBER1"),
            new System.Data.OleDb.OleDbParameter("NUMBER2", System.Data.OleDb.OleDbType.Integer, 0, "NUMBER2"),
            new System.Data.OleDb.OleDbParameter("NUMBER3", System.Data.OleDb.OleDbType.Integer, 0, "NUMBER3"),
            new System.Data.OleDb.OleDbParameter("NUMBER4", System.Data.OleDb.OleDbType.Integer, 0, "NUMBER4"),
            new System.Data.OleDb.OleDbParameter("NUMBER5", System.Data.OleDb.OleDbType.Integer, 0, "NUMBER5")});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT DATE1, ID, JOKERNUMBER, NUMBER1, NUMBER2, NUMBER3, NUMBER4, NUMBER5\r\nFROM " +
    "  JOKER1\r\nORDER BY DATE1";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection2;
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection2;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("DATE1", System.Data.OleDb.OleDbType.Date, 0, "DATE1"),
            new System.Data.OleDb.OleDbParameter("JOKERNUMBER", System.Data.OleDb.OleDbType.Integer, 0, "JOKERNUMBER"),
            new System.Data.OleDb.OleDbParameter("NUMBER1", System.Data.OleDb.OleDbType.Integer, 0, "NUMBER1"),
            new System.Data.OleDb.OleDbParameter("NUMBER2", System.Data.OleDb.OleDbType.Integer, 0, "NUMBER2"),
            new System.Data.OleDb.OleDbParameter("NUMBER3", System.Data.OleDb.OleDbType.Integer, 0, "NUMBER3"),
            new System.Data.OleDb.OleDbParameter("NUMBER4", System.Data.OleDb.OleDbType.Integer, 0, "NUMBER4"),
            new System.Data.OleDb.OleDbParameter("NUMBER5", System.Data.OleDb.OleDbType.Integer, 0, "NUMBER5"),
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_JOKERNUMBER", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JOKERNUMBER", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_JOKERNUMBER1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JOKERNUMBER", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_NUMBER1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_NUMBER11", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_NUMBER2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_NUMBER21", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER2", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_NUMBER3", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_NUMBER31", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER3", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_NUMBER4", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_NUMBER41", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER4", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_NUMBER5", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER5", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_NUMBER51", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NUMBER5", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_DATE1", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DATE1", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbConnection3
            // 
            this.oleDbConnection3.ConnectionString = resources.GetString("oleDbConnection3.ConnectionString");
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
            this.oleDbConnection1.InfoMessage += new System.Data.OleDb.OleDbInfoMessageEventHandler(this.oleDbConnection1_InfoMessage_3);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(24, 1751);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(190, 57);
            this.btnProcess.TabIndex = 24;
            this.btnProcess.Text = "PROCESS";
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "NewDataSet";
            this.dataSet2.Locale = new System.Globalization.CultureInfo("en-US");
            // 
            // btnJoker
            // 
            this.btnJoker.Location = new System.Drawing.Point(70, 218);
            this.btnJoker.Name = "btnJoker";
            this.btnJoker.Size = new System.Drawing.Size(256, 64);
            this.btnJoker.TabIndex = 25;
            this.btnJoker.Text = "DISPLAY  JOKERS  STATISTICS";
            this.btnJoker.Click += new System.EventHandler(this.btnJoker_Click);
            // 
            // btnNumber
            // 
            this.btnNumber.Location = new System.Drawing.Point(70, 305);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(256, 64);
            this.btnNumber.TabIndex = 26;
            this.btnNumber.Text = "DISPLAY  NUMBERS  STATISTICS";
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnUser);
            this.groupBox2.Controls.Add(this.labelSelect);
            this.groupBox2.Controls.Add(this.btnNumber);
            this.groupBox2.Controls.Add(this.txtUserSelect);
            this.groupBox2.Controls.Add(this.radioBtnDraw);
            this.groupBox2.Controls.Add(this.btnJoker);
            this.groupBox2.Location = new System.Drawing.Point(896, 2135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 380);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DEFINE  PARAMETERS";
            // 
            // radioBtnUser
            // 
            this.radioBtnUser.Location = new System.Drawing.Point(276, 59);
            this.radioBtnUser.Name = "radioBtnUser";
            this.radioBtnUser.Size = new System.Drawing.Size(144, 50);
            this.radioBtnUser.TabIndex = 4;
            this.radioBtnUser.Text = "USER SELECT";
            this.radioBtnUser.CheckedChanged += new System.EventHandler(this.radioBtnUser_CheckedChanged);
            // 
            // labelSelect
            // 
            this.labelSelect.Enabled = false;
            this.labelSelect.Location = new System.Drawing.Point(64, 120);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(190, 92);
            this.labelSelect.TabIndex = 3;
            this.labelSelect.Text = "DEFINE  NUMBER OF DRAWS";
            // 
            // txtUserSelect
            // 
            this.txtUserSelect.Enabled = false;
            this.txtUserSelect.Location = new System.Drawing.Point(276, 133);
            this.txtUserSelect.Name = "txtUserSelect";
            this.txtUserSelect.Size = new System.Drawing.Size(108, 31);
            this.txtUserSelect.TabIndex = 2;
            // 
            // radioBtnDraw
            // 
            this.radioBtnDraw.Checked = true;
            this.radioBtnDraw.Location = new System.Drawing.Point(90, 70);
            this.radioBtnDraw.Name = "radioBtnDraw";
            this.radioBtnDraw.Size = new System.Drawing.Size(174, 37);
            this.radioBtnDraw.TabIndex = 1;
            this.radioBtnDraw.TabStop = true;
            this.radioBtnDraw.Text = "ALL DRAWS";
            this.radioBtnDraw.CheckedChanged += new System.EventHandler(this.radioBtnDraw_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(24, 24);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(125, 29);
            this.radioButton4.TabIndex = 30;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "6_SCAN";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(24, 332);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(125, 29);
            this.radioButton3.TabIndex = 29;
            this.radioButton3.Text = "5_SCAN";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 270);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(137, 29);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.Text = "10_SCAN";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 81);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(125, 29);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.Text = "7_SCAN";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtResults.ContextMenuStrip = this.contextMenuStrip2;
            this.txtResults.Location = new System.Drawing.Point(1444, 1431);
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtResults.ShowSelectionMargin = true;
            this.txtResults.Size = new System.Drawing.Size(940, 563);
            this.txtResults.TabIndex = 28;
            this.txtResults.Text = "";
            this.txtResults.WordWrap = false;
            this.txtResults.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtResults_MouseClick);
            this.txtResults.TextChanged += new System.EventHandler(this.txtResults_TextChanged_1);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.AllowDrop = true;
            this.contextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip2.ShowCheckMargin = true;
            this.contextMenuStrip2.Size = new System.Drawing.Size(177, 118);
            this.contextMenuStrip2.TabStop = true;
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(176, 38);
            this.toolStripMenuItem4.Text = "COPY";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(176, 38);
            this.toolStripMenuItem5.Text = "CUT";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(176, 38);
            this.toolStripMenuItem6.Text = "PASTE";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 118);
            this.contextMenuStrip1.Text = "rrrr";
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 38);
            this.toolStripMenuItem1.Text = "PASTE";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.toolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(176, 38);
            this.toolStripMenuItem2.Text = "CUT";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.Yellow;
            this.toolStripMenuItem3.DoubleClickEnabled = true;
            this.toolStripMenuItem3.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(176, 38);
            this.toolStripMenuItem3.Text = "COPY";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // dataView1
            // 
            this.dataView1.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.dataView1_ListChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(24, 1815);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 52);
            this.button1.TabIndex = 30;
            this.button1.Text = "MANUAL_SCAN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(986, 2563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 105);
            this.button2.TabIndex = 31;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox15);
            this.groupBox4.Controls.Add(this.textBox14);
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Controls.Add(this.textBox12);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(594, 1688);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 419);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "15_MANUAL_SCAN/MATCH";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(154, 380);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(46, 31);
            this.textBox15.TabIndex = 14;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(154, 327);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(46, 31);
            this.textBox14.TabIndex = 13;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(44, 327);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(42, 31);
            this.textBox13.TabIndex = 12;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(154, 279);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(46, 31);
            this.textBox12.TabIndex = 11;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(44, 279);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(42, 31);
            this.textBox11.TabIndex = 10;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(154, 231);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(46, 31);
            this.textBox10.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(44, 231);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(42, 31);
            this.textBox9.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(154, 183);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(46, 31);
            this.textBox8.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(44, 183);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(42, 31);
            this.textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(154, 135);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(46, 31);
            this.textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(44, 135);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(42, 31);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(154, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(46, 31);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(44, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 31);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 31);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 31);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton8);
            this.groupBox5.Controls.Add(this.radioButton7);
            this.groupBox5.Controls.Add(this.radioButton4);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Location = new System.Drawing.Point(1086, 1699);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(310, 380);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "NUMS_CNT";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(24, 199);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(125, 29);
            this.radioButton8.TabIndex = 32;
            this.radioButton8.Text = "9_SCAN";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(24, 148);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(125, 29);
            this.radioButton7.TabIndex = 31;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "8_SCAN";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(24, 1867);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(190, 88);
            this.button13.TabIndex = 35;
            this.button13.Text = "AUTO_LEARNING_PREDICTING  START";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton6);
            this.groupBox6.Controls.Add(this.radioButton5);
            this.groupBox6.Location = new System.Drawing.Point(16, 2151);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(170, 172);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "MAN_AUTO";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(20, 96);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(101, 29);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "AUTO";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(16, 44);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(131, 29);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.Text = "MANUAL";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(56, 2075);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(80, 31);
            this.textBox16.TabIndex = 37;
            this.textBox16.Text = "0";
            this.textBox16.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 2051);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 2083);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 25);
            this.label10.TabIndex = 39;
            this.label10.Text = "AC";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(26, 1963);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 101);
            this.button4.TabIndex = 40;
            this.button4.Text = "AUTO_LEARNING_PREDICTING  STOP";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 2083);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 25);
            this.label11.TabIndex = 41;
            this.label11.Text = "MC";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(206, 2075);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(110, 31);
            this.textBox17.TabIndex = 42;
            this.textBox17.Text = "0";
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(216, 2024);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 25);
            this.label12.TabIndex = 43;
            this.label12.Text = "LI/DI";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(294, 2016);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(80, 31);
            this.textBox18.TabIndex = 44;
            this.textBox18.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(266, 1780);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(296, 29);
            this.checkBox2.TabIndex = 47;
            this.checkBox2.Text = "DATA_MINING_ENABLED";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Data_mine_support_btn
            // 
            this.Data_mine_support_btn.Enabled = false;
            this.Data_mine_support_btn.Location = new System.Drawing.Point(266, 1832);
            this.Data_mine_support_btn.Name = "Data_mine_support_btn";
            this.Data_mine_support_btn.Size = new System.Drawing.Size(298, 75);
            this.Data_mine_support_btn.TabIndex = 48;
            this.Data_mine_support_btn.Text = "Data_Mine_Support_Factor_Results";
            this.Data_mine_support_btn.UseVisualStyleBackColor = true;
            this.Data_mine_support_btn.Click += new System.EventHandler(this.Data_mine_support_btn_Click);
            // 
            // Data_mine_confidence_btn
            // 
            this.Data_mine_confidence_btn.Enabled = false;
            this.Data_mine_confidence_btn.Location = new System.Drawing.Point(266, 1919);
            this.Data_mine_confidence_btn.Name = "Data_mine_confidence_btn";
            this.Data_mine_confidence_btn.Size = new System.Drawing.Size(294, 75);
            this.Data_mine_confidence_btn.TabIndex = 50;
            this.Data_mine_confidence_btn.Text = "Data_Mine_Confidence_Factor_Results";
            this.Data_mine_confidence_btn.UseVisualStyleBackColor = true;
            this.Data_mine_confidence_btn.Click += new System.EventHandler(this.Data_mine_confidence_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton12);
            this.groupBox3.Controls.Add(this.radioButton11);
            this.groupBox3.Controls.Add(this.radioButton10);
            this.groupBox3.Controls.Add(this.radioButton9);
            this.groupBox3.Location = new System.Drawing.Point(926, 1699);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 408);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "WIN_CNT";
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Checked = true;
            this.radioButton12.Location = new System.Drawing.Point(14, 353);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(55, 29);
            this.radioButton12.TabIndex = 3;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "5";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(14, 257);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(55, 29);
            this.radioButton11.TabIndex = 2;
            this.radioButton11.Text = "4";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(14, 148);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(55, 29);
            this.radioButton10.TabIndex = 1;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "3";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(14, 54);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(55, 29);
            this.radioButton9.TabIndex = 0;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "2";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox8);
            this.groupBox7.Controls.Add(this.numericUpDown16);
            this.groupBox7.Controls.Add(this.numericUpDown15);
            this.groupBox7.Controls.Add(this.numericUpDown14);
            this.groupBox7.Controls.Add(this.numericUpDown13);
            this.groupBox7.Controls.Add(this.checkBox7);
            this.groupBox7.Controls.Add(this.numericUpDown10);
            this.groupBox7.Controls.Add(this.numericUpDown9);
            this.groupBox7.Controls.Add(this.numericUpDown8);
            this.groupBox7.Controls.Add(this.numericUpDown7);
            this.groupBox7.Controls.Add(this.numericUpDown6);
            this.groupBox7.Controls.Add(this.numericUpDown5);
            this.groupBox7.Controls.Add(this.numericUpDown4);
            this.groupBox7.Controls.Add(this.numericUpDown3);
            this.groupBox7.Controls.Add(this.numericUpDown2);
            this.groupBox7.Controls.Add(this.numericUpDown1);
            this.groupBox7.Controls.Add(this.checkBox6);
            this.groupBox7.Controls.Add(this.checkBox5);
            this.groupBox7.Controls.Add(this.checkBox4);
            this.groupBox7.Controls.Add(this.checkBox3);
            this.groupBox7.Controls.Add(this.checkBox1);
            this.groupBox7.Enabled = false;
            this.groupBox7.Location = new System.Drawing.Point(476, 2116);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(410, 323);
            this.groupBox7.TabIndex = 53;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "NEIGHBOURS_MAN_ENAB_MODE";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(26, 279);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(159, 29);
            this.checkBox8.TabIndex = 80;
            this.checkBox8.Text = "NUMBER_7";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // numericUpDown16
            // 
            this.numericUpDown16.Enabled = false;
            this.numericUpDown16.Location = new System.Drawing.Point(324, 273);
            this.numericUpDown16.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown16.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown16.Name = "numericUpDown16";
            this.numericUpDown16.Size = new System.Drawing.Size(86, 31);
            this.numericUpDown16.TabIndex = 79;
            // 
            // numericUpDown15
            // 
            this.numericUpDown15.Enabled = false;
            this.numericUpDown15.Location = new System.Drawing.Point(206, 273);
            this.numericUpDown15.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown15.Name = "numericUpDown15";
            this.numericUpDown15.Size = new System.Drawing.Size(108, 31);
            this.numericUpDown15.TabIndex = 78;
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.Enabled = false;
            this.numericUpDown14.Location = new System.Drawing.Point(324, 231);
            this.numericUpDown14.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown14.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(86, 31);
            this.numericUpDown14.TabIndex = 77;
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.Enabled = false;
            this.numericUpDown13.Location = new System.Drawing.Point(206, 225);
            this.numericUpDown13.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(108, 31);
            this.numericUpDown13.TabIndex = 76;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(26, 231);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(159, 29);
            this.checkBox7.TabIndex = 75;
            this.checkBox7.Text = "NUMBER_6";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Enabled = false;
            this.numericUpDown10.Location = new System.Drawing.Point(324, 185);
            this.numericUpDown10.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown10.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(92, 31);
            this.numericUpDown10.TabIndex = 69;
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Enabled = false;
            this.numericUpDown9.Location = new System.Drawing.Point(206, 181);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(108, 31);
            this.numericUpDown9.TabIndex = 68;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Enabled = false;
            this.numericUpDown8.Location = new System.Drawing.Point(324, 148);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown8.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(92, 31);
            this.numericUpDown8.TabIndex = 67;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Enabled = false;
            this.numericUpDown7.Location = new System.Drawing.Point(206, 150);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(108, 31);
            this.numericUpDown7.TabIndex = 66;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Enabled = false;
            this.numericUpDown6.Location = new System.Drawing.Point(324, 111);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown6.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(92, 31);
            this.numericUpDown6.TabIndex = 65;
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Enabled = false;
            this.numericUpDown5.Location = new System.Drawing.Point(206, 113);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(108, 31);
            this.numericUpDown5.TabIndex = 64;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Enabled = false;
            this.numericUpDown4.Location = new System.Drawing.Point(324, 76);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            19,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(92, 31);
            this.numericUpDown4.TabIndex = 63;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Enabled = false;
            this.numericUpDown3.Location = new System.Drawing.Point(206, 76);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(108, 31);
            this.numericUpDown3.TabIndex = 62;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(324, 35);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(92, 31);
            this.numericUpDown2.TabIndex = 61;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(206, 35);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(108, 31);
            this.numericUpDown1.TabIndex = 60;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(26, 190);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(159, 29);
            this.checkBox6.TabIndex = 59;
            this.checkBox6.Text = "NUMBER_5";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(26, 116);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(159, 29);
            this.checkBox5.TabIndex = 58;
            this.checkBox5.Text = "NUMBER_3";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(26, 155);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(159, 29);
            this.checkBox4.TabIndex = 57;
            this.checkBox4.Text = "NUMBER_4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(26, 81);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(159, 29);
            this.checkBox3.TabIndex = 56;
            this.checkBox3.Text = "NUMBER_2";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 29);
            this.checkBox1.TabIndex = 55;
            this.checkBox1.Text = "NUMBER_1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(219, 25);
            this.label13.TabIndex = 71;
            this.label13.Text = "NBM_DELTA_TOTAL";
            this.label13.Click += new System.EventHandler(this.label13_Click_1);
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Location = new System.Drawing.Point(250, 41);
            this.numericUpDown11.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown11.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(166, 31);
            this.numericUpDown11.TabIndex = 70;
            this.numericUpDown11.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.radioButton15);
            this.groupBox9.Controls.Add(this.radioButton14);
            this.groupBox9.Controls.Add(this.radioButton13);
            this.groupBox9.Location = new System.Drawing.Point(246, 2162);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(218, 174);
            this.groupBox9.TabIndex = 54;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "NBM_CONTROL";
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(24, 129);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(196, 29);
            this.radioButton15.TabIndex = 2;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "AUTO_ENABLE";
            this.radioButton15.UseVisualStyleBackColor = true;
            this.radioButton15.CheckedChanged += new System.EventHandler(this.radioButton15_CheckedChanged);
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Checked = true;
            this.radioButton14.Location = new System.Drawing.Point(24, 87);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(131, 29);
            this.radioButton14.TabIndex = 1;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "DISABLE";
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.radioButton14_CheckedChanged);
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(24, 44);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(185, 29);
            this.radioButton13.TabIndex = 0;
            this.radioButton13.Text = "MAN_ENABLE";
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.numericUpDown12);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.numericUpDown11);
            this.groupBox8.Enabled = false;
            this.groupBox8.Location = new System.Drawing.Point(456, 2487);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(438, 181);
            this.groupBox8.TabIndex = 70;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "NEIGHBOURS_AUTO_ENAB_MODE";
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Location = new System.Drawing.Point(250, 96);
            this.numericUpDown12.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown12.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(166, 31);
            this.numericUpDown12.TabIndex = 73;
            this.numericUpDown12.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 25);
            this.label14.TabIndex = 72;
            this.label14.Text = "NBM_NUM_COUNT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(386, 2024);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 25);
            this.label15.TabIndex = 71;
            this.label15.Text = "MM";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(326, 2075);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(88, 31);
            this.textBox21.TabIndex = 73;
            this.textBox21.Text = "0";
            this.textBox21.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            // 
            // txtResults2
            // 
            this.txtResults2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtResults2.ContextMenuStrip = this.contextMenuStrip1;
            this.txtResults2.Location = new System.Drawing.Point(1444, 1991);
            this.txtResults2.Name = "txtResults2";
            this.txtResults2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtResults2.ShowSelectionMargin = true;
            this.txtResults2.Size = new System.Drawing.Size(940, 648);
            this.txtResults2.TabIndex = 74;
            this.txtResults2.Text = "";
            this.txtResults2.WordWrap = false;
            this.txtResults2.TextChanged += new System.EventHandler(this.txtResults2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 938);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1430, 456);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged_1);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(224, 1679);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 81);
            this.button5.TabIndex = 76;
            this.button5.Text = "INSERT_ROW IN DATABASE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(424, 1679);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(182, 81);
            this.button6.TabIndex = 77;
            this.button6.Text = "UPDATE_DATABASE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BackColor = System.Drawing.Color.Yellow;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DataBindings.Add(new System.Windows.Forms.Binding("BindingSource", this.dataSet11, "JOKER1.ID", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N6"));
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(2384, 39);
            this.bindingNavigator1.TabIndex = 78;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(100, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown17);
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Location = new System.Drawing.Point(6, 2351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 164);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOCK_COUNT";
            // 
            // numericUpDown17
            // 
            this.numericUpDown17.Enabled = false;
            this.numericUpDown17.Location = new System.Drawing.Point(74, 103);
            this.numericUpDown17.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown17.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown17.Name = "numericUpDown17";
            this.numericUpDown17.Size = new System.Drawing.Size(240, 31);
            this.numericUpDown17.TabIndex = 1;
            this.numericUpDown17.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(74, 44);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(245, 29);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Text = "LOCK_MAX_COUNT";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(424, 2075);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(140, 31);
            this.textBox19.TabIndex = 80;
            this.textBox19.Text = "0";
            this.textBox19.TextChanged += new System.EventHandler(this.textBox19_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 2031);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 81;
            this.label1.Text = "C";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.checkBox10);
            this.groupBox10.Controls.Add(this.button8);
            this.groupBox10.Controls.Add(this.button7);
            this.groupBox10.Location = new System.Drawing.Point(34, 2528);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(400, 151);
            this.groupBox10.TabIndex = 82;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "SCAN_MODE";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(46, 35);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(342, 29);
            this.checkBox10.TabIndex = 2;
            this.checkBox10.Text = "AUTO_SCAN_MODE_ENABLE";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(194, 85);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 55);
            this.button8.TabIndex = 1;
            this.button8.Text = "STOP";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(4, 85);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(180, 55);
            this.button7.TabIndex = 0;
            this.button7.Text = "START";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(1634, 1086);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(592, 63);
            this.label2.TabIndex = 83;
            this.label2.Text = "QUERY EDITOR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox20.Location = new System.Drawing.Point(1764, 938);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(620, 69);
            this.textBox20.TabIndex = 84;
            this.textBox20.Text = "D:\\JOCKER4.mdb";
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(1440, 938);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 69);
            this.label3.TabIndex = 85;
            this.label3.Text = "CURRENT  DATABASE SOURCE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button9.Location = new System.Drawing.Point(1824, 1016);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(210, 66);
            this.button9.TabIndex = 86;
            this.button9.Text = "OPEN NEW  DATABASE ";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "mdb";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = " @\"C:\\\"";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Browse .mdb Files";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(0, 1400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1436, 63);
            this.label4.TabIndex = 87;
            this.label4.Text = "QUERY RESULTS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // draw1BindingSource
            // 
            this.draw1BindingSource.DataSource = typeof(ts3.draw1);
            this.draw1BindingSource.CurrentChanged += new System.EventHandler(this.draw1BindingSource_CurrentChanged);
            // 
            // form2BindingSource
            // 
            this.form2BindingSource.DataSource = typeof(ts3.Form2);
            // 
            // TableDisplay
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1676, 1084);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtResults2);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Data_mine_confidence_btn);
            this.Controls.Add(this.Data_mine_support_btn);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.dataGrid2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtQuery);
            this.Name = "TableDisplay";
            this.Text = "AI_NN_LIFETIME PRO";
            this.Load += new System.EventHandler(this.TableDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.draw1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }
          #endregion

          /// <summary>
          /// The main entry point for the application.
          /// </summary>
          [STAThread]
          static void Main()
          {
               //t1=new TableDisplay();
               //TableDisplay  tableDisplay=new TableDisplay();
               //

               Application.Run(new TableDisplay());
          }

          private void oleDbConnection1_InfoMessage(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
          {

          }

          private void oleDbDataAdapter1_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
          {

          }

          private void btnFind_Click(object sender, System.EventArgs e)
          {
               //System.Data.DataRow[] drFound;
               //drFound=this.dataSet1.Tables[0].Select("date LIKE" +"'111*'");
               //foreach(System.Data.DataRow dr in drFound)
               //{
               //this.dataGrid1.Update();

               //}

          }

          private void groupBox1_Enter(object sender, System.EventArgs e)
          {


          }

          private void TableDisplay_Load(object sender, System.EventArgs e)
          {

          }

          public void btnSubmit_Click(object sender, System.EventArgs e)
          {
               try
               {


                    oleDbDataAdapter1.SelectCommand.CommandText = txtQuery.Text;
                    dataSet2.Clear();
                    // int  ri1;    

                    // InitializeComponent();
                    oleDbDataAdapter1.Fill(dataSet2, "JOKER1");
                    dataGrid2.SetDataBinding(dataSet2, "JOKER1");
                    // 
                    //ri1=dataGrid2.CurrentRowIndex ;
                    //string   ri2;

                    //ri2 =ri1.ToString;
                    //statusTextBox.Text=ri1.ToString();;
                    //Display(dataSet2);
                    //if(last_used_query!="")
                    last_used_query = txtQuery.Text;

               }


               catch (System.Data.OleDb.OleDbException oleException)
               {
                    //MessageBox.Show(oleException.ToString());

                    DialogResult dr = MessageBox.Show("WRONG    QUERY..PLS  TRY AGAIN....  OR LOAD  LAST USED QUERY  BY PRESSING NO OR DEFAULT ONE  BY PRESSING YES.. EXAMPLE FORMAT SAMPLE  -select  *  from joker1  where   (number1=1 and number2=8 ) or  number3=12 -....DO YOU WANT TO PROCEED", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    //  DialogResult dr = MessageBox.Show("WARNING:THE  NEW SELECTED  DATABASE MUST BE THE SAME SCHEMA AS THIS SOFTWARE  IS DESIGNED....ANY OTHER SCHEMA  WILL BE DISCARDED.....DO YOU WANT TO PROCEED ? ", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Cancel)
                    {

                         return;
                    }

                    else if (dr == DialogResult.No)
                    {

                         //oleDbDataAdapter1.SelectCommand.CommandText = last_used_query;
                         txtQuery.Text = last_used_query;

                         oleDbDataAdapter1.SelectCommand.CommandText = txtQuery.Text;
                    }


                    else
                    {
                         txtQuery.Text = "select * from joker1  where (number1 = 1 and number2 = 8 ) or number3 = 12 ";

                         oleDbDataAdapter1.SelectCommand.CommandText = txtQuery.Text;
                         last_used_query = txtQuery.Text;
                    }

               }


          }


          public void Display(DataSet dataSet)
          {
               //int  ri1;

               // 
               //ri1=dataGrid1.CurrentRowIndex ;
               //string   ri2;

               //ri2 =ri1.ToString;
               //statusTextBox.Text=ri1.ToString();


               try
               {



                    DataTable dataTable = dataSet.Tables[0];
                    if (dataTable.Rows.Count != 0)
                    {
                         string dateString;



                         int recordNumber = (int)dataTable.Rows[ri4][1];

                         //txtId.Text=recordNumber.ToString();

                         recordNumber = (int)dataTable.Rows[ri4][3];

                         //txtNumber1.Text=recordNumber.ToString();

                         recordNumber = (int)dataTable.Rows[ri4][4];

                         //txtNumber2.Text=recordNumber.ToString();


                         recordNumber = (int)dataTable.Rows[ri4][5];

                         //txtNumber3.Text=recordNumber.ToString();


                         recordNumber = (int)dataTable.Rows[ri4][6];

                         //txtNumber4.Text=recordNumber.ToString();


                         recordNumber = (int)dataTable.Rows[ri4][7];

                         //txtNumber5.Text=recordNumber.ToString();
                         //
                         recordNumber = (int)dataTable.Rows[ri4][2];

                         //	txtJoker.Text=recordNumber.ToString();




                         dateString = dataTable.Rows[ri4][0].ToString();


                         // txtDate.Text=dateString.ToString();


                         // txtDate.Text=(string)dataTable.Rows[0][0];
                         //txtNumber1.Text=(int)dataTable.Rows[0][2];
                         // txtNumber2.Text=(int)dataTable.Rows[0][3];

                         // txtNumber3.Text=(int)dataTable.Rows[0][4];
                         // txtNumber4.Text=(int)dataTable.Rows[0][5];

                         //txtNumber5.Text=(int)dataTable.Rows[0][6];

                         // txtJoker.Text=(string)dataTable.Rows[0][7];

                    }

                    //	else  statusTextBox.Text += "\r\nNo  record  Was  found \r\n";




               }

               catch (System.Data.OleDb.OleDbException oleException)
               {
                    Console.WriteLine(oleException.StackTrace);
                    //	statusTextBox.Text += oleException.ToString();


               }



          }




          private void oleDbDataAdapter1_RowUpdated_1(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
          {

          }


          private void btvAdd_Click(object sender, System.EventArgs e)
          {

          }

          private void dataGrid1_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
          {


          }

          private void label3_Click(object sender, EventArgs e)
          {

          }

          private void oleDbConnection2_InfoMessage(object sender, OleDbInfoMessageEventArgs e)
          {

               // textBox20.Text = "";
               // textBox20.Text = "D:\\JOCKER4.mdb";


          }



          private void button9_Click(object sender, EventArgs e)

          {
               // MessageBox.Show("Not  yet  implemented//This is a test version");

               DialogResult dr = MessageBox.Show("WARNING:THE  NEW SELECTED  DATABASE MUST BE THE SAME SCHEMA AS THIS SOFTWARE  IS DESIGNED....ANY OTHER SCHEMA  WILL BE DISCARDED.....DO YOU WANT TO PROCEED ? ", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

               if (dr == DialogResult.Cancel || dr == DialogResult.No)
               {
                    return;
               }

               //" Provider =" +Microsoft.Jet.OLEDB.4.0+
               OpenFileDialog openFileDialog1 = new OpenFileDialog();



               //ShowDialog method displays the OpenFileDialog.

               openFileDialog1.ShowDialog();

               textBox20.Text = openFileDialog1.FileName;

               string connectionString = null;
               connectionString = "Provider =Microsoft.Jet.OleDb.4.0;Data Source =" + textBox20.Text + "; User ID = Admin; Mode = ReadWrite; Jet OLEDB:Engine Type = 5; Jet OLEDB:Database Locking Mode = 1; Jet OLEDB:Global Partial Bulk Ops = 2; Jet OLEDB:Global Bulk Transactions = 1; Jet OLEDB:Create System Database = False; Jet OLEDB:Encrypt Database = False; Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";

               OleDbConnection oleDbConnection10 = new OleDbConnection(connectionString);
               {
                    oleDbConnection4 = oleDbConnection10;

                    if ((conflag10 == 1))
                    {
                         oleDbConnection10.Close();
                         conflag10 = 0;
                         //dataSet1.Clear;
                         MessageBox.Show("Some Old  Database connection   was open and closed  ! ");
                    }
                    //  try
                    // {
                    //   OleDbCommand command = new OleDbCommand("select * from joker1 ", oleDbConnection10);

                    OleDbCommand command = new OleDbCommand("select  DATE1,ID,JOKERNUMBER,NUMBER1,NUMBER2,NUMBER3,NUMBER4,NUMBER5  from joker1 ", oleDbConnection10);


                    // }
                    // catch (Exception ex1)
                    //  {


                    //  MessageBox.Show("SCHEMA  VALIDATION ERROR");

                    // }

                    adapter = new OleDbDataAdapter(command);
                    // adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    //adapter.MissingMappingAction = MissingMappingAction.Error;
                    // adapter.MissingSchemaAction = MissingSchemaAction.Error;

                    if ((conflag2 == 1))
                    {
                         oleDbConnection2.Close();
                         conflag2 = 0;
                         MessageBox.Show("Some Old  Database connection   was open and closed  ! ");
                         // dataSet1.Clear();
                    }



                    // ";User ID ="+Admin+
                    //";Mode ="+ReadWrite +

                    //  "; Jet OLEDB:Database Locking Mode =" +1+
                    //   ";Jet OLEDB:Global Partial Bulk Ops =" +2+
                    //   ";Jet OLEDB:Global Bulk Transactions =" +1+
                    //  ";Jet OLEDB:Create System Database = "+ false +
                    //  ";Jet OLEDB:Encrypt Database ="+ false +
                    //  ";Jet OLEDB:Don't Copy Locale on Compact="+false+
                    //  ";Jet OLEDB:Compact Without Replica Repair="+false+
                    //   ";Jet OLEDB:SFP="+false;





                    try
                    {


                         //
                         // Required for Windows Form Designer support
                         //this

                         //textBox20.Text = "";
                         //textBox20.Text = "D:\\JOCKER4.mdb";


                         //oleDbConnection2.DataSource="D:\\JOCKER4.mdb";
                         //oleDbConnection2.Close;

                         //oleDbConnection10.Open();
                         {
                              //oleDbDataAdapter1.


                              // InitializeComponent();

                              // oleDbDataAdapter2 = oleDbDataAdapter1;

                              // dataSet4 = dataSet1;
                              dataSet4.Clear();


                              adapter.Fill(dataSet4, "joker1");


                              MessageBox.Show("Connection  with the  Database  " + textBox20.Text + " is active ! ");
                              conflag10 = 1;


                         }


                         {
                              // MessageBox.Show("Can not open connection ! ...No  Database  named  jocker4.mdb  was  found in the default  Directory   D:\\");
                         }

                         //DataTable    dataTable =dataSet1.Tables[0];

                         {
                              //dataGridView1.DataSource = dataSet1.Tables[0].DefaultView;
                              dataGridView1.DataSource = dataSet4.Tables["joker1"];

                         }

                         {
                              // MessageBox.Show("Can not open DataSet ! ");
                         }


                         // DataView  dataview  =dataSet1.Tables[0].DefaultView;
                         // dataView1.Sort="date ASC";
                         //dataGrid1.DataSource=dataview;
                         //dataGrid2.DataSource=dataView1;



                         {
                              dt1 = dataSet4.Tables["joker1"];

                              //  DataTable dataTable = dataSet4.Tables["joker1"];
                              txtUserSelect.Text = dt1.Rows.Count.ToString();
                              //dataGrid1.SetDataBinding(dataview,"joker1");
                              //   dt = dataTable;

                         }
                         // Display(dataSet1);

                         {
                              //MessageBox.Show("Can not open Tables ! ");
                         }
                         //
                         // TODO: Add any constructor code after InitializeComponent call
                         //





                         //oleDbConnection10.Close();
                         MessageBox.Show("Connection with database is active ");
                         MessageBox.Show("Connection string :" + oleDbConnection10.ConnectionString);

                         btnSubmit.Enabled = true;
                         btnProcess.Enabled = true;
                         button1.Enabled = true;
                         button13.Enabled = true;
                         button4.Enabled = true;
                         groupBox6.Enabled = true;
                         groupBox7.Enabled = true;
                         groupBox9.Enabled = true;
                         groupBox3.Enabled = true;
                         groupBox4.Enabled = true;
                         groupBox5.Enabled = true;
                         Data_mine_confidence_btn.Enabled = true;
                         Data_mine_support_btn.Enabled = true;
                         button7.Enabled = true;
                         button8.Enabled = true;
                         btnJoker.Enabled = true;
                         btnNumber.Enabled = true;

                         MessageBox.Show(" Valid schema database  was reloaded");


                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("SCHEMA   VALIDATION ERROR......" + "...Error_1 : " + ex.Message.ToString());
                         MessageBox.Show("Connection string :" + oleDbConnection10.ConnectionString);
                         dataSet4.Clear();
                         this.dataGridView1.DataSource = null;

                         //Then clear the rows:

                         this.dataGridView1.Rows.Clear();
                         //  oleDbConnection10.Close();
                         //  MessageBox.Show("CONNECTION  WAS CLOSED");
                         // conflag10 = 0;

                         btnSubmit.Enabled = false;
                         btnProcess.Enabled = false;
                         button1.Enabled = false;
                         button13.Enabled = false;
                         button4.Enabled = false;
                         groupBox6.Enabled = false;
                         groupBox7.Enabled = false;
                         groupBox9.Enabled = false;
                         groupBox3.Enabled = false;
                         groupBox4.Enabled = false;
                         groupBox5.Enabled = false;
                         Data_mine_confidence_btn.Enabled = false;
                         Data_mine_support_btn.Enabled = false;
                         button7.Enabled = false;
                         button8.Enabled = false;
                         btnJoker.Enabled = false;
                         btnNumber.Enabled = false;
                         button5.Enabled = false;
                         button6.Enabled = false;
                         MessageBox.Show("Pls try to reload a valid schema database");

                    }

               }

               //OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
               //builder.ConnectionString = @"Data Source="+textBox20.Text;
               //oleDbConnection2.ConnectionString="Provider="+ Microsoft.Jet.Oledb.4.0; @"Data Source=" + textBox20.Text;
               //  oleDbConnection2.Provider=@"Microsoft.Jet.Oledb.4.0";
               // Call the Add method to explicitly add key/value
               // pairs to the internal collection.
               // builder.Add("Provider", "Microsoft.Jet.Oledb.4.0");
               //builder.Add("Jet OLEDB:Database Password", "MyPassword!");
               // builder.Add("Jet OLEDB:System Database", @"C:\Workgroup.mdb");

               // Set up row-level locking.
               // builder.Add("Jet OLEDB:Database Locking Mode", 1);

               //  Console.WriteLine(builder.ConnectionString);
               // Console.WriteLine();



               //  return adapter;


               dataSet1 = dataSet4;


          }

          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
               // button6.Enabled = true;
          }
          private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
          {

               //button6.Enabled = true;


          }

          private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
          {
               //button6.Enabled = true;
          }

          private void dataGridView1_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
          {
               button6.Enabled = true;
          }

          private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
          {
               // button5.Enabled = true;
          }

          private void groupBox6_Enter(object sender, EventArgs e)
          {

          }

          private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
          {
               button5.Enabled = true;
          }

          private void label4_Click(object sender, EventArgs e)
          {

          }

          private void txtDate_TextChanged(object sender, System.EventArgs e)
          {

          }

          public void dataGrid2_CurrentCellChanged(object sender, System.EventArgs e)
          {

               int ri1;

               // MessageBox.Show("ok");
               // 
               ri1 = dataGrid2.CurrentRowIndex;
               //string   ri2;
               ri1 += 1;
               //ri2 =ri1.ToString;
               //statusTextBox.Text=ri1.ToString();
               ////ri1 += 1;

               //Console.WriteLine("TEST1");

               //MessageBox.Show("Col is  " + dataGrid1.CurrentCell.ColumnNumber + " ,Row is   " + dataGrid1.CurrentCell.RowNumber +  ", Value is " +  dataGrid1[dataGrid1.CurrentCell]);
               ri1 -= 1;
               ri4 = ri1;
               //Display(dataSet2 ); 





          }

          private void txtResults2_TextChanged(object sender, EventArgs e)
          {

          }

          private void textBox18_TextChanged(object sender, EventArgs e)
          {

          }

          private void textBox17_TextChanged(object sender, EventArgs e)
          {

          }

          private void textBox19_TextChanged_1(object sender, EventArgs e)
          {

          }

          public void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
          {
               // int ri1;
               // MessageBox.Show("ok");

               //	dataGrid1.AllowSorting=true;


               //ri1=dataGrid1.CurrentRowIndex ;
               //string   ri2;
               //ri1 += 1;
               ////ri2 =ri1.ToString;
               //	statusTextBox.Text=ri1.ToString();


               //Console.WriteLine("TEST1");

               //MessageBox.Show("Col is  " + dataGrid1.CurrentCell.ColumnNumber + " ,Row is   " + dataGrid1.CurrentCell.RowNumber +  ", Value is " +  dataGrid1[dataGrid1.CurrentCell]);
               //   ri1 -= 1;
               //   ri4=ri1;
               Display(dataSet1);
          }

          private void txtNumber1_TextChanged(object sender, System.EventArgs e)
          {

          }

          private void dataGrid1_Navigate_1(object sender, System.Windows.Forms.NavigateEventArgs ne)
          {

          }

          private void dataGrid2_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
          {

          }

          public void btnProcess_Click(object sender, System.EventArgs e)
          {//ri4=90;
               DataTable dataTable = dataSet1.Tables[0];
               //int ri12=0;
               //ri12=Convert.ToInt32(txtUserSelect.Text);
               //i3=Convert.ToInt32(txtUserSelect.Text);
               DialogBox1 myDialogBox1 = new DialogBox1(ref this.i3, ref this.dataSet1, ref this.oleDbDataAdapter1, ref this.oleDbConnection1);

               //myDialogBox1.MdiParent = this;

               //myDialogBox1.Show();
               if (myDialogBox1.ShowDialog() == DialogResult.OK)
               {
                    MessageBox.Show("LEARNING STARTED  IN THE DATABASE");

               }









          }

          private void oleDbDataAdapter1_RowUpdated_2(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
          {

          }

        private void button13_Click(object sender, EventArgs e)
        {
            // int gm = 0;
            f14 = 1;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox5.Enabled = false;
            groupBox7.Enabled = false;
            groupBox10.Enabled = false;
            groupBox8.Enabled = false;
            groupBox6.Enabled = false;
            checkBox2.Enabled = false;
            button1.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            groupBox9.Enabled = false;
            btnProcess.Enabled = false;
            btnSubmit.Enabled = false;
            button13.Enabled = false;
            button4.Enabled = true;
            if (man1 == 0 && f15 == 1 && dm1 == 0)
            {
                CheckForIllegalCrossThreadCalls = false;

                textBox16.Text = Convert.ToString(0);
                endflag = 0;
                new Thread(new ThreadStart(stat_auto_scan)).Start();
                //auto_scan();
            }
            else
             if (man1 == 0 && f15 == 1 && dm1 == 1)
            {
                CheckForIllegalCrossThreadCalls = false;

                textBox16.Text = Convert.ToString(0);
                endflag = 0;
                new Thread(new ThreadStart(dm_auto_scan)).Start();
                //auto_scan2();
            }
        }

        private void oleDbConnection1_InfoMessage_1(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
          {

          }

          private void oleDbConnection1_InfoMessage_2(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
          {

          }

          public void btnJoker_Click(object sender, System.EventArgs e)
          {



               DataTable dataTable = dataSet1.Tables[0];
               int i2 = 0;

               int i = 0;
               int[] j1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
               string output = "";
               try
               {
                    if (radioBtnDraw.Checked)
                    {




                         MessageBox.Show("ALL DRAWS IS SELECTED BY THE USER");
                    }
                    else
                        if (radioBtnUser.Checked)
                    {
                         if (MessageBox.Show("SELECTION REPORT", "YOU HAVE SELECTED : " + txtUserSelect.Text, MessageBoxButtons.OKCancel) == DialogResult.OK)
                         {


                              for (i = 1; i <= 20; i++)//SELECT JOKERS 1-20
                              {
                                   i1 = Convert.ToInt32(txtUserSelect.Text);//SELECT NUMBER OF DRAWS
                                                                            //int i2=0;
                                   this.i3 = i1 - 1;


                                   for (i2 = 0; i2 < i1; i2++)
                                   {
                                        //if(i==7)


                                        if (i == (int)dataTable.Rows[i2][2])
                                        {
                                             //MessageBox.Show(dataTable.Rows[i2][2].ToString());
                                             j1[i - 1]++;//positions  1-20 goes 0-19  in array j1

                                        }

                                        //txtJoker.Text=recordNumber.ToString();

                                        //if(i2==20)


                                        // break;
                                   }



                                   //MessageBox.Show  ("COUNT DOWN FINISHED ",i.ToString() );


                              }
                              output += "1=" + j1[0] + ",2=" + j1[1] + ",3=" + j1[2] + ",4=" + j1[3] + ",5=" + j1[4] + ",6=" + j1[5] + ",7=" + j1[6] + ",8=" + j1[7] + ",9=" + j1[8] + ",10=" + j1[9] + ",11=" + j1[10] + ",12=" + j1[11] + ",13=" + j1[12] + ",14=" + j1[13] + ",15=" + j1[14] + ",16=" + j1[15] + ",17=" + j1[16] + ",18=" + j1[17] + ",19=" + j1[18] + ",20=" + j1[19];
                              //output += "    "+j1[1]+"    "+j1[2]+"    "+j1[3]+"    "+j1[4]+"    "+j1[5]+"    "+j1[6]+"    "+j1[7]+"    "+j1[8]+"    "+j1[9]+"    "+j1[10]+"    "+j1[11]+"    "+j1[12]+"    "+j1[13]+"    "+j1[14]+"    "+j1[15]+"    "+j1[16]+"    "+j1[17]+"    "+j1[18]+"    "+j1[19];//+"\t"+j1[20,100]+"\n";

                              txtResults.Text = output;
                              //MessageBox.Show  (output,"JOKERS STATISTICS",MessageBoxButtons.OK,MessageBoxIcon.Information ); 
                         }

                    }
               }
               catch (System.IndexOutOfRangeException)
               {
                    MessageBox.Show(dataTable.Rows[i2][2].ToString(), "ERROR");
                    MessageBox.Show(j1[i].ToString(), "ERROR");
               }

               //MessageBox.Show("i3="+this.i3.ToString());





          }



          public void btnNumber_Click(object sender, System.EventArgs e)
          {

               fill_list();


          }

          public void fill_list()
          {

               DataTable dataTable = dataSet1.Tables[0];
               int i2 = 0, i21 = 0, i22 = 0, i23 = 0, i24 = 0, i25 = 0, i31 = 0, i32 = 0, i33 = 0, i34 = 0, i35 = 0, i26 = 0;
               int i40 = 0, i41 = 0, i42 = 0, i43 = 0, i44 = 0, i45 = 0, i46 = 0, i48 = 0;

               int i1 = 0;
               int i = 0;
               int i5 = 0, i4 = 0, i6 = 0, i7 = 0, i8 = 0, i9 = 0, i3 = 0;


               int[] j1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
               int[] j10 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
               int[] j11 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
               int[] j12 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
               int[] j14 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

               string output = "";
               draws.Clear();
               try
               {
                    if (radioBtnDraw.Checked)
                    {




                         MessageBox.Show("ALL DRAWS IS SELECTED BY THE USER");
                    }
                    else
                        if (radioBtnUser.Checked)
                         MessageBox.Show(" USER  DRAWS IS SELECTED BY THE USER");

                    else
                            if (!radioBtnUser.Checked && !radioBtnDraw.Checked)
                         MessageBox.Show("MANUAL  MODE  IS SELECTED BY THE USER");

                    {
                         if (MessageBox.Show("SELECTION REPORT", "YOU HAVE SELECTED : " + txtUserSelect.Text, MessageBoxButtons.OKCancel) == DialogResult.OK)
                         {
                              i1 = Convert.ToInt32(txtUserSelect.Text);//SELECT NUMBER OF DRAWS
                              int c1 = 1;
                              this.Cursor = Cursors.WaitCursor;

                              for (i2 = 0; i2 < i1; i2++)
                              //for( i=1;i<=45;i++)//SELECT NUMBERS 1-45
                              {


                                   //int i2=0;
                                   for (i = 1; i <= 45; i++)//SELECT NUMBERS 1-45

                                   //for(  i2=0;i2<i1;i2++)
                                   {
                                        //if(i==7)


                                        if (i == (int)dataTable.Rows[i2][3])
                                        {
                                             j11[i - 1] = i2 - j10[i - 1];//calculate  delay and store it in  array j11  i.e array  j11[current_number-1]=draw_index-arrayj10[current_number-1]
                                                                          //MessageBox.Show(dataTable.Rows[i2][2].ToString());
                                             j1[i - 1]++;//calculate  occurances  i.e increment  array j1[current_number-1]
                                             j10[i - 1] = i2;//store draw_index  in array  j10  for calculation of delay i.e array  j10[current_number-1]=draw_index  

                                             i21 = j1[i - 1];//pass object constructor
                                             i31 = j11[i - 1];//pass  object constructor
                                             i3 = 1;//set flag 
                                             i46 = i;
                                             if (i46 % 2 == 0)
                                                  i26++;//calculate even/odds



                                        }
                                        else if (i == (int)dataTable.Rows[i2][4])
                                        {
                                             j11[i - 1] = i2 - j10[i - 1];
                                             j1[i - 1]++;
                                             j10[i - 1] = i2;
                                             i22 = j1[i - 1];
                                             i3 = 1;
                                             i32 = j11[i - 1];
                                             i46 = i;
                                             if (i46 % 2 == 0)
                                                  i26++;


                                        }
                                        else if (i == (int)dataTable.Rows[i2][5])
                                        {
                                             j11[i - 1] = i2 - j10[i - 1];

                                             j1[i - 1]++;
                                             j10[i - 1] = i2;
                                             i3 = 1;
                                             i23 = j1[i - 1];
                                             i33 = j11[i - 1];
                                             i46 = i;
                                             if (i46 % 2 == 0)
                                                  i26++;


                                        }

                                        else if (i == (int)dataTable.Rows[i2][6])
                                        {
                                             j11[i - 1] = i2 - j10[i - 1];
                                             j1[i - 1]++;
                                             j10[i - 1] = i2;
                                             i3 = 1;
                                             i24 = j1[i - 1];
                                             i34 = j11[i - 1];
                                             i46 = i;
                                             if (i46 % 2 == 0)
                                                  i26++;

                                        }
                                        else if (i == (int)dataTable.Rows[i2][7])
                                        {
                                             j11[i - 1] = i2 - j10[i - 1];

                                             j1[i - 1]++;
                                             j10[i - 1] = i2;
                                             i3 = 1;
                                             i25 = j1[i - 1];
                                             i35 = j11[i - 1];
                                             i46 = i;
                                             if (i46 % 2 == 0)
                                                  i26++;
                                        }

                                        //txtJoker.Text=recordNumber.ToString();

                                        //if(i2==20)
                                        if (i3 != 1)
                                        {
                                             j11[i - 1] = i2 - j10[i - 1];

                                             //j1[i-1]++;
                                             //j10[i-1]=i2; 


                                        }
                                        i3 = 0;







                                   }
                                   if (i26 == 0)//count history  stats  for even/odd(0,1,2,3,4,5)
                                        i40++;
                                   else
                                       if (i26 == 1)
                                        i41++;
                                   else
                                           if (i26 == 2)
                                        i42++;
                                   else
                                               if (i26 == 3)
                                        i43++;
                                   else
                                                   if (i26 == 4)
                                        i44++;
                                   else
                                                       if (i26 == 5)
                                        i45++;

                                   i26 = 0;
                                   i48 = i2 * 5 / 45;//average occurances


                                   // foreach (draw1 draw2 in draws)
                                   // {

                                   // }


                                   //MessageBox.Show  ("COUNT DOWN FINISHED ",i.ToString() );
                                   try
                                   {

                                        draws.Add(new draw1((DateTime)dataTable.Rows[i2][0], (int)dataTable.Rows[i2][1], (int)dataTable.Rows[i2][2], (int)dataTable.Rows[i2][3], (int)dataTable.Rows[i2][4], (int)dataTable.Rows[i2][5], (int)dataTable.Rows[i2][6], (int)dataTable.Rows[i2][7], i21, i31, i22, i32, i23, i33, i24, i34, i25, i35, i40, i41, i42, i43, i44, i45, i48, j11[0], j11[1], j11[2], j11[3], j11[4], j11[5], j11[6], j11[7], j11[8], j11[9], j11[10], j11[11], j11[12], j11[13], j11[14], j11[15], j11[16], j11[17], j11[18], j11[19], j11[20], j11[21], j11[22], j11[23], j11[24], j11[25], j11[26], j11[27], j11[28], j11[29], j11[30], j11[31], j11[32], j11[33], j11[34], j11[35], j11[36], j11[37], j11[38], j11[39], j11[40], j11[41], j11[42], j11[43], j11[44], j1[0], j1[1], j1[2], j1[3], j1[4], j1[5], j1[6], j1[7], j1[8], j1[9], j1[10], j1[11], j1[12], j1[13], j1[14], j1[15], j1[16], j1[17], j1[18], j1[19], j1[20], j1[21], j1[22], j1[23], j1[24], j1[25], j1[26], j1[27], j1[28], j1[29], j1[30], j1[31], j1[32], j1[33], j1[34], j1[35], j1[36], j1[37], j1[38], j1[39], j1[40], j1[41], j1[42], j1[43], j1[44]));//add objects in list  with specific parameters for constructor
                                   }

                                   catch (Exception)
                                   {


                                        MessageBox.Show("Error in Draw1");
                                   }

                                   // break;
                              }
                              this.Cursor = Cursors.Default;


                              // Array.Sort(j11,j1);
                              output += "OCCURANCES " + "  DELAYS  " + "\n1=" + j1[0] + "		" + j11[0] + "\n2=" + j1[1] + "		" + j11[1] + "\n3=" + j1[2] + "		" + j11[2] + "\n4=" + j1[3] + "		" + j11[3] + "\n5=" + j1[4] + "		" + j11[4] + "\n6=" + j1[5] + "		" + j11[5] + "\n7=" + j1[6] + "		" + j11[6] + "\n8=" + j1[7] + "		" + j11[7] + "\n9=" + j1[8] + "		" + j11[8] + "\n10=" + j1[9] + "		" + j11[9] + "\n11=" + j1[10] + "		" + j11[10] + "\n12=" + j1[11] + "		" + j11[11] + "\n13=" + j1[12] + "		" + j11[12] + "\n14=" + j1[13] + "		" + j11[13] + "\n15=" + j1[14] + "		" + j11[14] + "\n16=" + j1[15] + "		" + j11[15] + "\n17=" + j1[16] + "		" + j11[16] + "\n18=" + j1[17] + "		" + j11[17] + "\n19=" + j1[18] + "		" + j11[18] + "\n20=" + j1[19] + "		" + j11[19] + "\n21=" + j1[20] + "		" + j11[20] + "\n22=" + j1[21] + "		" + j11[21] + "\n23=" + j1[22] + "		" + j11[22] + "\n24=" + j1[23] + "		" + j11[23] + "\n25=" + j1[24] + "		" + j11[24] + "\n26=" + j1[25] + "		" + j11[25] + "\n27=" + j1[26] + "		" + j11[26] + "\n28=" + j1[27] + "		" + j11[27] + "\n29=" + j1[28] + "		" + j11[28] + "\n30=" + j1[29] + "		" + j11[29] + "\n31=" + j1[30] + "		" + j11[30] + "\n32=" + j1[31] + "		" + j11[31] + "\n33=" + j1[32] + "		" + j11[32] + "\n34=" + j1[33] + "		" + j11[33] + "\n35=" + j1[34] + "		" + j11[34] + "\n36=" + j1[35] + "		" + j11[35] + "\n37=" + j1[36] + "		" + j11[36] + "\n38=" + j1[37] + "		" + j11[37] + "\n39=" + j1[38] + "		" + j11[38] + "\n40=" + j1[39] + "		" + j11[39] + "\n41=" + j1[40] + "		" + j11[40] + "\n42=" + j1[41] + "		" + j11[41] + "\n43=" + j1[42] + "		" + j11[42] + "\n44=" + j1[43] + "		" + j11[43] + "\n45=" + j1[44] + "		" + j11[44];
                              //output += "    "+j1[1]+"    "+j1[2]+"    "+j1[3]+"    "+j1[4]+"    "+j1[5]+"    "+j1[6]+"    "+j1[7]+"    "+j1[8]+"    "+j1[9]+"    "+j1[10]+"    "+j1[11]+"    "+j1[12]+"    "+j1[13]+"    "+j1[14]+"    "+j1[15]+"    "+j1[16]+"    "+j1[17]+"    "+j1[18]+"    "+j1[19];//+"\t"+j1[20,100]+"\n";


                              output += "\n\naverage occurance= " + draws.Count * 5 / 45;







                              txtResults.Text = output;


                              if (f14 == 1)
                              {
                                   f14 = 0;

                                   return;
                              }


                              if (MessageBox.Show("PROCESSING FINISHED ,\n PROCEED WITH LEARNING!", "JOKERS MAGIC STATISTICS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                              {





                                   /*   Form2 myDialogBox2 = new Form2(this.draws);


                                        if (myDialogBox2.ShowDialog() == DialogResult.OK)
                                        {
                                            MessageBox.Show("LEARNING STARTED  IN THE DATABASE");

                                        }

                                        */

                                   //myDialogBox1.MdiParent = this;


                              }
                         }

                    }
               }
               catch (System.IndexOutOfRangeException)
               {
                    MessageBox.Show(dataTable.Rows[i2][2].ToString(), "ERROR  NUMBER  1");
                    MessageBox.Show(j1[i].ToString(), "ERROR   NUMBER 2");
               }
               f18 = 1;
               draws.Clear();
          }

          private void radioBtnUser_CheckedChanged(object sender, System.EventArgs e)
          {

               //this.groupBox1.Enabled = false;
               this.button1.Enabled = false;
               this.labelSelect.Enabled = true;
               this.txtUserSelect.Enabled = true;
               DataTable dataTable = dataSet1.Tables[0];
               txtUserSelect.Text = dataTable.Rows.Count.ToString();

               this.btnNumber.Enabled = true;
               this.btnJoker.Enabled = true;


          }

          private void radioBtnDraw_CheckedChanged(object sender, System.EventArgs e)
          {
               this.labelSelect.Enabled = false;
               this.txtUserSelect.Enabled = false;
               // this.groupBox1.Enabled = false;
               //this.button1.Enabled = false;
               DataTable dataTable = dataSet1.Tables[0];
               txtUserSelect.Text = dataTable.Rows.Count.ToString();

               this.btnNumber.Enabled = true;
               this.btnJoker.Enabled = true;
          }

          private void txtResults_TextChanged(object sender, System.EventArgs e)
          {
               //ri4=20;

          }

          private void btnUpdate_Click(object sender, System.EventArgs e)
          {
               //MessageBox.Show("date"+dataView1.Table.Columns[0]);
               // System.Data.OleDb.OleDbCommandBuilder   cmdBuilder=new System.Data.OleDb.OleDbCommandBuilder(oleDbDataAdapter1);
               //OleCommandBuilder  cmdBuilder =new  oleCommandBuilder();

               //try
               //{

               //oleDbDataAdapter1.UpdateCommand=cmdBuilder.GetUpdateCommand();




               //if(dataSet1.HasChanges()==true)
               //{
               //dataSet1.GetChanges();
               //MessageBox.Show("HasChanges=true");

               // oleDbDataAdapter1.UpdateCommand.CommandText="UPDATE joker1 SET jokernumber=40 ";

               //oleDbDataAdapter1.Update(dataSet1,"joker1");
               //oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();
               //dataSet1.AcceptChanges();
               //}
               //}

               //catch(System.Data.OleDb.OleDbException  oleException)
               //{
               //MessageBox.Show("error"+oleException.ToString());
               //}


          }

          private void oleDbConnection1_InfoMessage_3(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
          {

          }

          private void dataView1_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
          {

          }

          private void label1_Click(object sender, System.EventArgs e)
          {

          }

          private void txtResults_TextChanged_1(object sender, EventArgs e)
          {

          }

          private void draw1BindingSource_CurrentChanged(object sender, EventArgs e)
          {

          }

          private void radioButton1_CheckedChanged(object sender, EventArgs e)
          {
               if (radioButton5.Checked == true)
               {

                    //    this.groupBox1.Enabled = false;
                    this.groupBox4.Enabled = true;



                    //groupBox4.Enabled = false;






                    // this.groupBox1.Enabled = true;
                    //  this.button1.Enabled = true;
                    //  this.labelSelect.Enabled = false;
                    //   this.txtUserSelect.Enabled = false;
                    //  this.btnNumber.Enabled = false;
                    //  this.btnJoker.Enabled = false;
                    //  int ri1 = 0;
                    //  ri1 += 1;
                    //  f15 = 0;
                    //  f5 = 1;
                    //ri2 =ri1.ToString;
                    //   statusTextBox.Text = ri1.ToString();


                    //Console.WriteLine("TEST1");

                    //MessageBox.Show("Col is  " + dataGrid1.CurrentCell.ColumnNumber + " ,Row is   " + dataGrid1.CurrentCell.RowNumber +  ", Value is " +  dataGrid1[dataGrid1.CurrentCell]);
                    //  ri1 -= 1;
                    //  ri4 = ri1;
                    //   Display(dataSet1);




               }

               flag_num = 7;
               f15 = 1;
               f5 = 0;


            if (radioButton1.Checked == true)
            {
                MessageBox.Show(" NUMBER_7 MODE WAS SELECTED....AI SOFTWARE  WILL BE SELECTED TO REFLECT THIS CHOISE");
                ai = 7;
            }
        }

          private void button1_Click(object sender, EventArgs e)
          {
               f14 = 1;
               if (f15 == 1 && man1 == 1)
               {
                    //f15 = 0;

                    manual_scan15();
               }
               else
                   if (f5 == 1 && man1 == 1)
                    manual_scan();
          }
          private void manual_scan()
          {

               string output1 = " ";
               txtResults.Text = output1;
               if (f18 == 1)
               {
                    fill_list();
                    f18 = 0;
               }
               f14 = 0;
               f12 = 0;
               for (f12 = 0; f12 < draws.Count; f12++)
               {
                    // if (Convert.ToInt32(txtNumber1.Text) == draws[f12].num1 || Convert.ToInt32(txtNumber1.Text) == draws[f12].num2 || Convert.ToInt32(txtNumber1.Text) == draws[f12].num3 || Convert.ToInt32(txtNumber1.Text)== draws[f12].num4 || Convert.ToInt32(txtNumber1.Text) == draws[f12].num5)
                    {
                         f16++;
                    }
                    // if (Convert.ToInt32(txtNumber2.Text) == draws[f12].num1 || Convert.ToInt32(txtNumber2.Text) == draws[f12].num2 || Convert.ToInt32(txtNumber2.Text) == draws[f12].num3 ||Convert.ToInt32(txtNumber2.Text) == draws[f12].num4 || Convert.ToInt32(txtNumber2.Text) == draws[f12].num5)
                    {
                         f16++;
                    }
                    // if (Convert.ToInt32(txtNumber3.Text) == draws[f12].num1 || Convert.ToInt32(txtNumber3.Text) == draws[f12].num2 || Convert.ToInt32(txtNumber3.Text) == draws[f12].num3 || Convert.ToInt32(txtNumber3.Text) == draws[f12].num4 || Convert.ToInt32(txtNumber3.Text) == draws[f12].num5)
                    {
                         f16++;
                    }
                    // if (Convert.ToInt32(txtNumber4.Text) == draws[f12].num1 || Convert.ToInt32(txtNumber4.Text) == draws[f12].num2 || Convert.ToInt32(txtNumber4.Text) == draws[f12].num3 || Convert.ToInt32(txtNumber4.Text) == draws[f12].num4 || Convert.ToInt32(txtNumber4.Text) == draws[f12].num5)
                    {
                         f16++;
                    }

                    // if (Convert.ToInt32(txtNumber5.Text) == draws[f12].num1 || Convert.ToInt32(txtNumber5.Text) == draws[f12].num2 || Convert.ToInt32(txtNumber5.Text) == draws[f12].num3 || Convert.ToInt32(txtNumber5.Text) == draws[f12].num4 || Convert.ToInt32(txtNumber5.Text) == draws[f12].num5)
                    {
                         f16++;
                    }
                    if (f16 > 2)
                    {
                         f16 = 0;


                         output1 += draws[f12].date2.ToString() + " " + draws[f12].num1.ToString() + " " + draws[f12].num2.ToString() + " " + draws[f12].num3.ToString() + " " + draws[f12].num4.ToString() + " " + draws[f12].num5.ToString() + "\n";


                    }
                    f16 = 0;





               }
               txtResults.Text = output1;

               output1 = "";


          }



          public void manual_scan15()
          {

               string output1 = " ";
               txtResults.Text = output1;
               if (f18 == 1)
               {
                    fill_list();
                    f18 = 0;
               }
               f14 = 0;
               f12 = 0;
               for (f12 = 0; f12 < draws.Count; f12++)
               {
                    if (Convert.ToInt32(textBox1.Text) == draws[f12].num1 || Convert.ToInt32(textBox1.Text) == draws[f12].num2 || Convert.ToInt32(textBox1.Text) == draws[f12].num3 || Convert.ToInt32(textBox1.Text) == draws[f12].num4 || Convert.ToInt32(textBox1.Text) == draws[f12].num5)
                    {
                         f16++;
                    }
                    if (Convert.ToInt32(textBox2.Text) == draws[f12].num1 || Convert.ToInt32(textBox2.Text) == draws[f12].num2 || Convert.ToInt32(textBox2.Text) == draws[f12].num3 || Convert.ToInt32(textBox2.Text) == draws[f12].num4 || Convert.ToInt32(textBox2.Text) == draws[f12].num5)
                    {
                         f16++;
                    }
                    if (Convert.ToInt32(textBox3.Text) == draws[f12].num1 || Convert.ToInt32(textBox3.Text) == draws[f12].num2 || Convert.ToInt32(textBox3.Text) == draws[f12].num3 || Convert.ToInt32(textBox3.Text) == draws[f12].num4 || Convert.ToInt32(textBox3.Text) == draws[f12].num5)
                    {
                         f16++;
                    }
                    if (Convert.ToInt32(textBox4.Text) == draws[f12].num1 || Convert.ToInt32(textBox4.Text) == draws[f12].num2 || Convert.ToInt32(textBox4.Text) == draws[f12].num3 || Convert.ToInt32(textBox4.Text) == draws[f12].num4 || Convert.ToInt32(textBox4.Text) == draws[f12].num5)
                    {
                         f16++;
                    }

                    if (Convert.ToInt32(textBox5.Text) == draws[f12].num1 || Convert.ToInt32(textBox5.Text) == draws[f12].num2 || Convert.ToInt32(textBox5.Text) == draws[f12].num3 || Convert.ToInt32(textBox5.Text) == draws[f12].num4 || Convert.ToInt32(textBox5.Text) == draws[f12].num5)
                    {
                         f16++;
                    }
                    if (Convert.ToInt32(textBox6.Text) == draws[f12].num1 || Convert.ToInt32(textBox6.Text) == draws[f12].num2 || Convert.ToInt32(textBox6.Text) == draws[f12].num3 || Convert.ToInt32(textBox6.Text) == draws[f12].num4 || Convert.ToInt32(textBox6.Text) == draws[f12].num5)
                    {
                         f16++;
                    }
                    if (Convert.ToInt32(textBox7.Text) == draws[f12].num1 || Convert.ToInt32(textBox7.Text) == draws[f12].num2 || Convert.ToInt32(textBox7.Text) == draws[f12].num3 || Convert.ToInt32(textBox7.Text) == draws[f12].num4 || Convert.ToInt32(textBox7.Text) == draws[f12].num5)
                    {
                         f16++;
                    }
                    if (Convert.ToInt32(textBox8.Text) == draws[f12].num1 || Convert.ToInt32(textBox8.Text) == draws[f12].num2 || Convert.ToInt32(textBox8.Text) == draws[f12].num3 || Convert.ToInt32(textBox8.Text) == draws[f12].num4 || Convert.ToInt32(textBox8.Text) == draws[f12].num5)
                    {
                         f16++;
                    }
                    if (Convert.ToInt32(textBox9.Text) == draws[f12].num1 || Convert.ToInt32(textBox9.Text) == draws[f12].num2 || Convert.ToInt32(textBox9.Text) == draws[f12].num3 || Convert.ToInt32(textBox9.Text) == draws[f12].num4 || Convert.ToInt32(textBox9.Text) == draws[f12].num5)
                    {
                         f16++;
                    }

                    if (Convert.ToInt32(textBox10.Text) == draws[f12].num1 || Convert.ToInt32(textBox10.Text) == draws[f12].num2 || Convert.ToInt32(textBox10.Text) == draws[f12].num3 || Convert.ToInt32(textBox10.Text) == draws[f12].num4 || Convert.ToInt32(textBox10.Text) == draws[f12].num5)
                    {
                         f16++;
                    }

                    if (Convert.ToInt32(textBox11.Text) == draws[f12].num1 || Convert.ToInt32(textBox11.Text) == draws[f12].num2 || Convert.ToInt32(textBox11.Text) == draws[f12].num3 || Convert.ToInt32(textBox11.Text) == draws[f12].num4 || Convert.ToInt32(textBox11.Text) == draws[f12].num5)
                    {
                         f16++;
                    }
                    if (Convert.ToInt32(textBox12.Text) == draws[f12].num1 || Convert.ToInt32(textBox12.Text) == draws[f12].num2 || Convert.ToInt32(textBox12.Text) == draws[f12].num3 || Convert.ToInt32(textBox12.Text) == draws[f12].num4 || Convert.ToInt32(textBox12.Text) == draws[f12].num5)
                    {
                         f16++;
                    }
                    if (Convert.ToInt32(textBox13.Text) == draws[f12].num1 || Convert.ToInt32(textBox13.Text) == draws[f12].num2 || Convert.ToInt32(textBox13.Text) == draws[f12].num3 || Convert.ToInt32(textBox13.Text) == draws[f12].num4 || Convert.ToInt32(textBox13.Text) == draws[f12].num5)
                    {
                         f16++;
                    }
                    if (Convert.ToInt32(textBox14.Text) == draws[f12].num1 || Convert.ToInt32(textBox14.Text) == draws[f12].num2 || Convert.ToInt32(textBox14.Text) == draws[f12].num3 || Convert.ToInt32(textBox14.Text) == draws[f12].num4 || Convert.ToInt32(textBox14.Text) == draws[f12].num5)
                    {
                         f16++;
                    }

                    if (Convert.ToInt32(textBox15.Text) == draws[f12].num1 || Convert.ToInt32(textBox15.Text) == draws[f12].num2 || Convert.ToInt32(textBox15.Text) == draws[f12].num3 || Convert.ToInt32(textBox15.Text) == draws[f12].num4 || Convert.ToInt32(textBox15.Text) == draws[f12].num5)
                    {
                         f16++;
                    }


                    if (f16 == win_cnt)
                    {
                         f16 = 0;


                         output1 += draws[f12].date2.ToString() + " " + draws[f12].num1.ToString() + " " + draws[f12].num2.ToString() + " " + draws[f12].num3.ToString() + " " + draws[f12].num4.ToString() + " " + draws[f12].num5.ToString() + "\n";


                    }
                    f16 = 0;





               }
               txtResults.Text = output1;

               output1 = "";







          }

          private void button2_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          private void groupBox4_Enter(object sender, EventArgs e)
          {

          }


          private void radioButton3_Click(object Sender, EventArgs e)
          {
               if (radioButton5.Checked == true)
               {
                    //  this.groupBox1.Enabled = false;
                    this.groupBox4.Enabled = true;

               }
               flag_num = 15;
               f15 = 1;
               f5 = 0;


          }




          private void radioButton3_CheckedChanged(object sender, EventArgs e)
          {

               if (gm == 0)
               {
                    MessageBox.Show("mode 6 must  must run first to enable ghost mode");
                    radioButton3.Checked = false;
                    radioButton4.Checked = true;
                    return; }
               if (radioButton5.Checked == true)
               {
                    // this.groupBox1.Enabled = false;
                    this.groupBox4.Enabled = true;

               }
               flag_num = 5;
               ghost_search = 1;
               f15 = 1;
               f5 = 0;


          }

          private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
          {

          }

          private void radioButton4_CheckedChanged(object sender, EventArgs e)
          {
               if (radioButton5.Checked == true)
               {
                    // this.groupBox1.Enabled = false;
                    this.groupBox4.Enabled = true;

               }
               flag_num = 6;
               f15 = 1;
               f5 = 0;
            if (radioButton4.Checked == true)
            {
                MessageBox.Show(" NUMBER_6 MODE WAS SELECTED....AI SOFTWARE  WILL BE SELECTED TO REFLECT THIS CHOISE");
                ai = 6;
            }
          }

          private void radioButton5_CheckedChanged(object sender, EventArgs e)
          {
               man1 = 1;
               //   groupBox1.Enabled = true;

               groupBox4.Enabled = true;
               button1.Enabled = true;
               radioButton1.Enabled = true;
               radioButton2.Enabled = true;
               radioButton3.Enabled = true;
               radioButton4.Enabled = true;

               button13.Enabled = false;
          }

          private void radioButton6_CheckedChanged(object sender, EventArgs e)
          {
               man1 = 0;
               radioButton1.Enabled = true;
               radioButton2.Enabled = true;
               radioButton3.Enabled = true;
               radioButton4.Enabled = true;
               button13.Enabled = true;
               groupBox4.Enabled = false;
               // groupBox1.Enabled = false;

               button1.Enabled = false;



          }
          int sas = 0;
          int sas1 = 0;


        private void button3_Click(object sender, EventArgs e)
          {
               
               // int gm = 0;
               f14 = 1;
               groupBox1.Enabled = false;
               groupBox2.Enabled = false;
               groupBox3.Enabled = false;
               groupBox5.Enabled = false;
               groupBox7.Enabled = false;
               groupBox10.Enabled = false;
               groupBox8.Enabled = false;
               groupBox6.Enabled = false;
               checkBox2.Enabled = false;
               button1.Enabled = false;
               button5.Enabled = false;
               button6.Enabled = false;
               groupBox9.Enabled = false;
               btnProcess.Enabled = false;
               btnSubmit.Enabled = false;
               button13.Enabled = false;
               button4.Enabled = true;
               if (man1 == 0 && f15 == 1 && dm1 == 0)
               {
                    CheckForIllegalCrossThreadCalls = false;

                    textBox16.Text = Convert.ToString(0);
                    endflag = 0;
                    new Thread(new ThreadStart(stat_auto_scan)).Start();
                    //auto_scan();
               }
               else
                if (man1 == 0 && f15 == 1 && dm1 == 1)
               {
                    CheckForIllegalCrossThreadCalls = false;

                    textBox16.Text = Convert.ToString(0);
                    endflag = 0;
                    new Thread(new ThreadStart(dm_auto_scan)).Start();
                    //auto_scan2();
               }


          }
          int[] occ = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

          int containsDuplicates;
          public void stat_auto_scan1()
          {

               int[] h161 = new int[8];

               int n = 1;
               // int cnt191 = 0;
               MessageBox.Show("START_AUTO_SCAN1_THREAD....STARTED....LAST COMBINATION  WAS EXTRACTED FROM HISTORY AND IS UNDER PROCESSING..", draws.Count.ToString());
               // str:
               //  for (sas = 100000000; sas > -1000000000; --sas)
               ///  { for (sas1 = 100000000; sas1 > -1000000000; --sas1) ;
               //      
               //       }
               //goto str;
               //++sas;
               //add_history_7();
               int[] hd=new int  [8];
               int error = 0;
               int d33 = 0;
               int term_flag = 0;
               int h18 = 0;
               int h12 = 0;
               bool h10 = false;
               int h9 = 0;
               int h8 = 0;
               int h5 = flag_num;
               Thread.Sleep(300000);
bool flagstart = true;
               int h4 = 0;


 int h20 = 0; ///
               h20 = h3[1, 0];
               if (h20 == 1)
                    term_flag = 1;
               int cnt19length = 0;
               int h2 = history_7.Length;
               occ[1] = adhi - 1;
               int cnt191 = 0;
            //int[] h131 = { 0, 0, 0, 0, 0, 0, 0, 0};
            int[] h131 = new int[flag_num];
                           int errorflag = 0;
               n = 0;
               MessageBox.Show("START_AUTO_SCAN1_THREAD..DELAY 5 MINUTES...FOR MAXIMUM...COMBINATIONS...RESULTS..AS...INDICATES...THE CURRENT ..LAST ..ONE.. IS.. UNDER ..PROCESS  " + occ[1].ToString()+ " TOTAL CURRENT SCORE");

               int cc3 = 0;

                    do
                    {
                         // int[] h131 = { 0, 0, 0, 0, 0, 0, 0, 0,};

                         for (int h14 = 0; h14 < flag_num; h14++)
                         {
                              h3[1, h14] = history_7[adhi - n, h14];
                              // h131[14]= history_7[adhi - cnt19, h14];
                         }
                         for (int h15 = 0; h15 < flag_num; h15++)
                         {
                              h131[h15] = h3[1, h15];
                              //  h131[15] = history_7[adhi - cnt19, h14];


                         }

                         Array.Sort(h131);
                         containsDuplicates = h131.Distinct().Count();
                         //   bool containsDuplicates = h131.Distinct().
                         if (containsDuplicates < flag_num||h131[flag_num-1]>39)
                         {
                              error = 1;
                    int flg = 0;
                    // if ((h3[1, 0] == 0) || (h3[1, 1] == 0) || (h3[1, 2] == 0) || (h3[1, 3] == 0) || (h3[1, 4] == 0) || (h3[1, 5] == 0) || (h3[1, 6] == 0) || (h3[1, 7] == 0))
                    for(flg=0;flg<flag_num;flg++)
                    if ((h3[1,flg])==0)
                    {
                                   MessageBox.Show(" END OF SELECTED COMBINATIONS");
                              }
                              else
                                   MessageBox.Show("ERROR DUPLICATE IN ARRAY OR  INVALID NUMBER COMBINATION ");
                         if ( h131[flag_num-1] > 39)
                         {
                              MessageBox.Show("INVALID NUMBER COMBINATION  IN SEQUENCE  LINE "+ n +"NUMBER  8 OF SEQUENCE IS LARGER THAN THE UPPER PERMITTED LIMIT 39...IT IS " + h131[7] +"   ");

                         }
                              break;
                         }

                         for (int h16 = 0; h16 < flag_num; h16++)
                         {

                              h3[1, h16] = h131[h16];

                              try
                              {
                                   if ((h3[1, h16]) == 0)
                                   {

                                        // throw (Exception   );
                                        throw new ArgumentOutOfRangeException("Not any number Can Be Zero ");
                                   }
                              }

                              catch (Exception e)
                              {
                                   MessageBox.Show("Error  in" + String.Concat(e.StackTrace, e.Message + "   "));
                                   error = 1;
                                   break;
                              }

                              // {
                              //     errorflag = 1;
                              //       goto loop8;
                              //  }
                              //  h131[15] = history_7[adhi - cnt19, h14];
                         }

                         if (error == 1)
                         {
                         MessageBox.Show("Error  in error=1");
                         error = 0;

                              break;
                         }

                    // if((h3[1,0] || h3[1,1] || h3[1, 2] || h3[1, 3] || h3[1, 4] || h3[1, 5] || h3[1, 6] || h3[1, 7])==0)
                    loop8:
                    if (errorflag == 1)
                    {
                         MessageBox.Show("Error  in errorflag=1" );
                         break;
                    }
                    lock (this)
                    {

                         for (d33 = 0; d33 < flag_num; d33++)
                         {
                              h20 = h3[1, d33];

                              loop1:

                              for (int h25 = 0; h25 < flag_num; h25++)
                              {
                                   h131[h25] = h3[1, h25];
                                   //  h131[15] = history_7[adhi - cnt19, h14];


                              }

                              Array.Sort(h131);

                              containsDuplicates = h131.Distinct().Count();
                              //   bool containsDuplicates = h131.Distinct().
                              if (containsDuplicates < flag_num)
                              {
                                   error = 1;
                                   MessageBox.Show("ERROR DUPLICATE IN ARRAY");
                                   break;
                              }
                              h12 = 0;
                              // lock(threadLock)
                              // { 
                              //  lock (this)
                              //  {


                              for (h4 = 0; h4 < draws.Count; h4++)
                              {

                                   h8 = 0;// if(h4>2220)
                                   //  MessageBox.Show("START_AUTO_SCAN5_THREAD_PROCESSING_INSIDE_LOOP", h4.ToString());
                                   for (cc3 = 0; cc3 < flag_num; cc3++)
                                   {

                                        if (h3[1, cc3] == draws[h4].num1 || h3[1, cc3] == draws[h4].num2 || h3[1, cc3] == draws[h4].num3 || h3[1, cc3] == draws[h4].num4 || h3[1, cc3] == draws[h4].num5)
                                        {
                                             h8++;

                                             // del15[c3] = 0;//if hit  a number is reset to 0 in the  win5
                                             // numtemp15[c3]++;//counts  the  times a number is hit  in the  win5
                                        }





                                   }
                                   if (h8 == 5)
                                   {//del15[c3]++;//counts  the  times a number is not  hit




                                        h12++;
                                        // if (h12 > 6)
                                        //  { MessageBox.Show("HIHIHIHIHIHI....CHECK CAREFULLY FOR THE BUG"); }
                                        h8 = 0;
                                   }
                                   h8 = 0;
                              }
                              //   }
                              // if (h12 > 6)
                              // { MessageBox.Show("HIHIHIHIHIHI....CHECK CAREFULLY FOR THE BUG"); }
                              // List < draw1 >= new List<draw1>;
                             
                              for (int h151 = 0; h151 < flag_num; h151++)
                              {
                                   h161[h151] = h3[1, h151];
                                   //  h131[15] = history_7[adhi - cnt19, h14];


                              }
bool ca = hd.SequenceEqual(h161);
                              if ((flagstart == true) ||(( h12 >= h18)&&(h18>=6)&&!(ca)))
                              {
                                   MessageBox.Show("START_AUTO_SCAN1_THREAD....STARTED_RESULTS..AS..INDICATED....FOR COMBINATION  " + h3[1, 0].ToString() + "  " + h3[1, 1].ToString() + "  " + h3[1, 2].ToString() + "  " + h3[1, 3].ToString() + "  " + h3[1, 4].ToString() + "  " + h3[1, 5].ToString() + "  " + h3[1, 6].ToString() + "  " + h3[1, 7].ToString() + "  " + "  FROM HISTORY_7_SCORE.  " + h12.ToString() + "       ");
                                 //  h18 = h12;//
                                   flagstart = false;
                                   MessageBox.Show("CONTINUE_AUTO_SCAN1_THREAD FOR LARGER COMBINATIONS  WITH SCORE  " + h12.ToString() + " FROM  HISTORY_7...");

                              }
                              
                              if ((h12 >= h18) && (((h18 >= 6) || (h18 == 0)) && !(ca))) 
                              {
                                   h18 = h12;
                                   h161.CopyTo(hd,0);

                                   if (h18 >= 6)
                                        MessageBox.Show("H18 FROM CONTINUE_AUTO_SCAN1_THREAD FOR LARGER COMBINATIONS  HAS SUCCEEDED LARGE  SCORE THAN  " + h12.ToString() + " FROM  HISTORY_7..FOR COMBINATION.  " + h3[1, 0].ToString() + "  " + h3[1, 1].ToString() + "  " + h3[1, 2].ToString() + "  " + h3[1, 3].ToString() + "  " + h3[1, 4].ToString() + "  " + h3[1, 5].ToString() + "  " + h3[1, 6].ToString() + "  " + h3[1, 7].ToString() + "  ");

                                   h12 = 0;

                              }
                              h12 = 0;


                              if ((h3[1, d33] < 39))
                              {
                                   h3[1, d33] = h3[1, d33] + 1;
                                   goto loop10;
                              }
                              if (h20 != 1)
                              {
                                   h3[1, d33] = 1;
                                   // goto loop1;
                              }
                              else
                                   break;
                              loop10:

                              // term_flag = 1;
                              //if (h3[1, 0] == 1)
                              // { h3[1, 0] = h3[1, 0] + 1;
                              loop2:
                              //   }
                              switch (d33)
                              {
                                   case 0:
                                        if ((h3[1, d33] != h3[1, 1] && h3[1, d33] != h3[1, 2] && h3[1, d33] != h3[1, 3] && h3[1, d33] != h3[1, 4] && h3[1, d33] != h3[1, 5] && h3[1, d33] != h3[1, 6] && h3[1, d33] != h3[1, 7]))
                                        {
                                             // h3[1, 0] = h3[1, 0] + 2;
                                             if (h3[1, d33] == h20)
                                                  goto default;
                                             if ((h3[1, d33] < 40))
                                                  goto loop1;
                                             if (h20 != 1)
                                             {
                                                  h3[1, d33] = 1;
                                                  goto loop1;
                                             }
                                             else
                                                  goto default;

                                        }

                                        h3[1, d33] = h3[1, d33] + 1;
                                        goto loop2;



                                   case 1:
                                        if ((h3[1, d33] != h3[1, 0] && h3[1, d33] != h3[1, 2] && h3[1, d33] != h3[1, 3] && h3[1, d33] != h3[1, 4] && h3[1, d33] != h3[1, 5] && h3[1, d33] != h3[1, 6] && h3[1, d33] != h3[1, 7]))
                                        {
                                             // h3[1, 0] = h3[1, 0] + 2;
                                             if (h3[1, d33] == h20)
                                                  goto default;
                                             if ((h3[1, d33] < 40))
                                                  goto loop1;
                                             if (h20 != 1)
                                             {
                                                  h3[1, d33] = 1;
                                                  goto loop1;
                                             }
                                             else
                                                  goto default;

                                        }
                                        h3[1, d33] = h3[1, d33] + 1;
                                        goto loop2;

                                   case 2:
                                        if ((h3[1, d33] != h3[1, 1] && h3[1, d33] != h3[1, 0] && h3[1, d33] != h3[1, 3] && h3[1, d33] != h3[1, 4] && h3[1, d33] != h3[1, 5] && h3[1, d33] != h3[1, 6] && h3[1, d33] != h3[1, 7]))
                                        {
                                             // h3[1, 0] = h3[1, 0] + 2;
                                             if (h3[1, d33] == h20)
                                                  goto default;
                                             if ((h3[1, d33] < 40))
                                                  goto loop1;
                                             if (h20 != 1)
                                             {
                                                  h3[1, d33] = 1;
                                                  goto loop1;
                                             }
                                             else
                                                  goto default;

                                        }
                                        h3[1, d33] = h3[1, d33] + 1;
                                        goto loop2;

                                   case 3:
                                        if ((h3[1, d33] != h3[1, 1] && h3[1, d33] != h3[1, 2] && h3[1, d33] != h3[1, 0] && h3[1, d33] != h3[1, 4] && h3[1, d33] != h3[1, 5] && h3[1, d33] != h3[1, 6] && h3[1, d33] != h3[1, 7]))
                                        {
                                             // h3[1, 0] = h3[1, 0] + 2;
                                             if (h3[1, d33] == h20)
                                                  goto default;
                                             if ((h3[1, d33] < 40))
                                                  goto loop1;
                                             if (h20 != 1)
                                             {
                                                  h3[1, d33] = 1;
                                                  goto loop1;
                                             }
                                             else
                                                  goto default;

                                        }
                                        h3[1, d33] = h3[1, d33] + 1;
                                        goto loop2;

                                   case 4:
                                        if ((h3[1, d33] != h3[1, 1] && h3[1, d33] != h3[1, 2] && h3[1, d33] != h3[1, 3] && h3[1, d33] != h3[1, 0] && h3[1, d33] != h3[1, 5] && h3[1, d33] != h3[1, 6] && h3[1, d33] != h3[1, 7]))
                                        {
                                             // h3[1, 0] = h3[1, 0] + 2;
                                             if (h3[1, d33] == h20)
                                                  goto default;
                                             if ((h3[1, d33] < 40))
                                                  goto loop1;
                                             if (h20 != 1)
                                             {
                                                  h3[1, d33] = 1;
                                                  goto loop1;
                                             }
                                             else
                                                  goto default;

                                        }
                                        h3[1, d33] = h3[1, d33] + 1;
                                        goto loop2;

                                   case 5:
                                        if ((h3[1, d33] != h3[1, 1] && h3[1, d33] != h3[1, 2] && h3[1, d33] != h3[1, 3] && h3[1, d33] != h3[1, 4] && h3[1, d33] != h3[1, 0] && h3[1, d33] != h3[1, 6] && h3[1, d33] != h3[1, 7]))
                                        {
                                             // h3[1, 0] = h3[1, 0] + 2;
                                             if (h3[1, d33] == h20)
                                                  goto default;
                                             if ((h3[1, d33] < 40))
                                                  goto loop1;
                                             if (h20 != 1)
                                             {
                                                  h3[1, d33] = 1;
                                                  goto loop1;
                                             }
                                             else
                                                  goto default;

                                        }
                                        h3[1, d33] = h3[1, d33] + 1;
                                        goto loop2;

                                   case 6:
                                        if ((h3[1, d33] != h3[1, 1] && h3[1, d33] != h3[1, 2] && h3[1, d33] != h3[1, 3] && h3[1, d33] != h3[1, 4] && h3[1, d33] != h3[1, 5] && h3[1, d33] != h3[1, 0] && h3[1, d33] != h3[1, 7]))
                                        {
                                             // h3[1, 0] = h3[1, 0] + 2;
                                             if (h3[1, d33] == h20)
                                                  goto default;
                                             if ((h3[1, d33] < 40))
                                                  goto loop1;
                                             if (h20 != 1)
                                             {
                                                  h3[1, d33] = 1;
                                                  goto loop1;
                                             }
                                             else
                                                  goto default;

                                        }
                                        h3[1, d33] = h3[1, d33] + 1;
                                        goto loop2;

                                   case 7:
                                        if ((h3[1, d33] != h3[1, 1] && h3[1, d33] != h3[1, 2] && h3[1, d33] != h3[1, 3] && h3[1, d33] != h3[1, 4] && h3[1, d33] != h3[1, 5] && h3[1, d33] != h3[1, 6] && h3[1, d33] != h3[1, 0]))
                                        {
                                             // h3[1, 0] = h3[1, 0] + 2;
                                             if (h3[1, d33] == h20)
                                                  goto default;
                                             if ((h3[1, d33] < 40))
                                                  goto loop1;
                                             if (h20 != 1)
                                             {
                                                  h3[1, d33] = 1;
                                                  goto loop1;
                                             }
                                             else
                                                  goto default;

                                        }
                                        h3[1, d33] = h3[1, d33] + 1;
                                        goto loop2;

                                   default:
                                        break;


                              }






                         }


                         if (error == 1)
                         {
                              error = 0;
                              break;
                         }

                         n++;
                         //  lock (this)
                         // {
                         cnt19--;


                         if (cnt19 <= 0)//first level  check comb
                         {
                              cnt1919--;//second level  check comb
                              if (cnt1919 <= 0)
                                   goto loop5;

                         }

                         loop5:
                         if (cnt1919 <= 0)
                         {
                              cnt191919--;//third level  check comb
                              if (cnt191919 <= 0)
                                   goto loop6;
                         }
                         // cnt19--;first level comb
                         //cnt1919--;second level comb
                         // cnt191919--;third level comb

                         loop6:

                         cnt191++;
                    }
                         //   }

                    } while (cnt191919 > 0 || h3[1, 1] == 0 || h3[1, 2] == 0 || h3[1, 3] == 0 || h3[1, 4] == 0 || h3[1, 5] == 0 || h3[1, 6] == 0 || h3[1, 0] == 0);

               
               MessageBox.Show("END_OF_AUTO_SCAN1_THREAD....FOR_ALL_FLAG_NUMS_NUMBER_ALL_LAST MAX COMBINATIONS.  " + cnt191.ToString() + "  FROM HISTORY_7 WITH MAX SCORE  ."+ h18.ToString()+"  ");

                  new Thread(new ThreadStart(stat_auto_scan2)).Start();
          }

        //NEW START_AUTO_SCAN6

        public void stat_auto_scan11()
        {

            int[] h161 = new int[8];

            int n = 1;
            // int cnt191 = 0;
            MessageBox.Show("START_AUTO_SCAN11_THREAD....STARTED....LAST COMBINATION  WAS EXTRACTED FROM HISTORY AND IS UNDER PROCESSING..MODIFICATION FROM  SCAN1 IS THAT ALL CLOSE NEIGHBOURS ARE  IDENTIFIED AND THE MOST PRIVILEGED NEIGHBOURHOODS ARE  SELECTED..AND TESTED WITH THE AI/MACHINE LEARNING/DEEP LEARNING  SOFTWARE", draws.Count.ToString());
            // str:
            //  for (sas = 100000000; sas > -1000000000; --sas)
            ///  { for (sas1 = 100000000; sas1 > -1000000000; --sas1) ;
            //      
            //       }
            //goto str;
            //++sas;
            //add_history_7();
            int[] hd = new int[8];
            int error = 0;
            int d33 = 0;
            int term_flag = 0;
            int h18 = 0;
            int h12 = 0;
            bool h10 = false;
            int h9 = 0;
            int h8 = 0;
            int h5 = flag_num;
           // Thread.Sleep(300000);
            bool flagstart = true;
            int h4 = 0;


            int h20 = 0; ///
            h20 = h3[1, 0];
            if (h20 == 1)
                term_flag = 1;
            int cnt19length = 0;
            int h2 = history_7.Length;
            occ[1] = adhi - 1;
            int cnt191 = 0;
            //int[] h131 = { 0, 0, 0, 0, 0, 0, 0, 0};
            int[] h131 = new int[flag_num];
            int errorflag = 0;
            n = 0;
            MessageBox.Show("START_AUTO_SCAN11_THREAD..HISTORY RECORDS  FILES ARE RECOVERED AND EVALUATED...FOR MAXIMUM...COMBINATIONS...RESULTS..AS...INDICATES...THE CURRENT ..LAST ..ONE.. IS.. UNDER ..PROCESS  " + occ[1].ToString() + " TOTAL CURRENT SCORE");

            int cc3 = 0;

            do
            {
                // int[] h131 = { 0, 0, 0, 0, 0, 0, 0, 0,};

                for (int h14 = 0; h14 < flag_num; h14++)
                {
                    h3[1, h14] = history_7[adhi - n, h14];
                    // h131[14]= history_7[adhi - cnt19, h14];
                }
                for (int h15 = 0; h15 < flag_num; h15++)
                {
                    h131[h15] = h3[1, h15];
                    //  h131[15] = history_7[adhi - cnt19, h14];


                }

                Array.Sort(h131);
                containsDuplicates = h131.Distinct().Count();
                //   bool containsDuplicates = h131.Distinct().
                if (containsDuplicates < flag_num || h131[flag_num - 1] > 39)
                {
                    error = 1;
                    int flg = 0;
                    // if ((h3[1, 0] == 0) || (h3[1, 1] == 0) || (h3[1, 2] == 0) || (h3[1, 3] == 0) || (h3[1, 4] == 0) || (h3[1, 5] == 0) || (h3[1, 6] == 0) || (h3[1, 7] == 0))
                    for (flg = 0; flg < flag_num; flg++)
                        if ((h3[1, flg]) == 0)
                        {
                            MessageBox.Show(" END OF SELECTED COMBINATIONS");
                        }
                        else
                            MessageBox.Show("ERROR DUPLICATE IN ARRAY OR  INVALID NUMBER COMBINATION ");
                    if (h131[flag_num - 1] > 39)
                    {
                        MessageBox.Show("INVALID NUMBER COMBINATION  IN SEQUENCE  LINE " + n + "NUMBER  8 OF SEQUENCE IS LARGER THAN THE UPPER PERMITTED LIMIT 39...IT IS " + h131[7] + "   ");

                    }
                    break;
                }

                for (int h16 = 0; h16 < flag_num; h16++)
                {

                    h3[1, h16] = h131[h16];

                    try
                    {
                        if ((h3[1, h16]) == 0)
                        {

                            // throw (Exception   );
                            throw new ArgumentOutOfRangeException("Not any number Can Be Zero ");
                        }
                    }

                    catch (Exception e)
                    {
                        MessageBox.Show("Error  in" + String.Concat(e.StackTrace, e.Message + "   "));
                        error = 1;
                        break;
                    }

                    // {
                    //     errorflag = 1;
                    //       goto loop8;
                    //  }
                    //  h131[15] = history_7[adhi - cnt19, h14];
                }

                if (error == 1)
                {
                    MessageBox.Show("Error  in error=1");
                    error = 0;

                    break;
                }

            // if((h3[1,0] || h3[1,1] || h3[1, 2] || h3[1, 3] || h3[1, 4] || h3[1, 5] || h3[1, 6] || h3[1, 7])==0)
            loop8:
                if (errorflag == 1)
                {
                    MessageBox.Show("Error  in errorflag=1");
                    break;
                }
                lock (this)
                {

                    for (d33 = 0; d33 < flag_num; d33++)
                    {
                        h20 = h3[1, d33];

                    loop1:

                        for (int h25 = 0; h25 < flag_num; h25++)
                        {
                            h131[h25] = h3[1, h25];
                            //  h131[15] = history_7[adhi - cnt19, h14];


                        }

                        Array.Sort(h131);

                        containsDuplicates = h131.Distinct().Count();
                        //   bool containsDuplicates = h131.Distinct().
                        if (containsDuplicates < flag_num)
                        {
                            error = 1;
                            MessageBox.Show("ERROR DUPLICATE IN ARRAY");
                            break;
                        }
                        h12 = 0;
                        // lock(threadLock)
                        // { 
                        //  lock (this)
                        //  {


                        for (h4 = 0; h4 < draws.Count; h4++)
                        {

                            h8 = 0;// if(h4>2220)
                                   //  MessageBox.Show("START_AUTO_SCAN5_THREAD_PROCESSING_INSIDE_LOOP", h4.ToString());
                            for (cc3 = 0; cc3 < flag_num; cc3++)
                            {

                                if (h3[1, cc3] == draws[h4].num1 || h3[1, cc3] == draws[h4].num2 || h3[1, cc3] == draws[h4].num3 || h3[1, cc3] == draws[h4].num4 || h3[1, cc3] == draws[h4].num5)
                                {
                                    h8++;

                                    // del15[c3] = 0;//if hit  a number is reset to 0 in the  win5
                                    // numtemp15[c3]++;//counts  the  times a number is hit  in the  win5
                                }





                            }
                            if (h8 == 5)
                            {//del15[c3]++;//counts  the  times a number is not  hit




                                h12++;
                                // if (h12 > 6)
                                //  { MessageBox.Show("HIHIHIHIHIHI....CHECK CAREFULLY FOR THE BUG"); }
                                h8 = 0;
                            }
                            h8 = 0;
                        }
                        //   }
                        // if (h12 > 6)
                        // { MessageBox.Show("HIHIHIHIHIHI....CHECK CAREFULLY FOR THE BUG"); }
                        // List < draw1 >= new List<draw1>;

                        for (int h151 = 0; h151 < flag_num; h151++)
                        {
                            h161[h151] = h3[1, h151];
                            //  h131[15] = history_7[adhi - cnt19, h14];


                        }
                        bool ca = hd.SequenceEqual(h161);
                        if ((flagstart == true) || ((h12 >= h18) && (h18 >= 6) && !(ca)))
                        {
                            MessageBox.Show("START_AUTO_SCAN11_THREAD....STARTED_RESULTS..AS..INDICATED....FOR COMBINATION  " + h3[1, 0].ToString() + "  " + h3[1, 1].ToString() + "  " + h3[1, 2].ToString() + "  " + h3[1, 3].ToString() + "  " + h3[1, 4].ToString() + "  " + h3[1, 5].ToString() + "  " + h3[1, 6].ToString() + "  " + h3[1, 7].ToString() + "  " + "  FROM HISTORY_7_SCORE.  " + h12.ToString() + "       ");
                            //  h18 = h12;//
                            flagstart = false;
                            MessageBox.Show("CONTINUE_AUTO_SCAN11_THREAD FOR LARGER COMBINATIONS  WITH SCORE  " + h12.ToString() + " FROM  HISTORY_7...");

                        }

                        if ((h12 >= h18) && (((h18 >= 6) || (h18 == 0)) && !(ca)))
                        {
                            h18 = h12;
                            h161.CopyTo(hd, 0);

                            if (h18 >= 6)
                                MessageBox.Show("H18 FROM CONTINUE_AUTO_SCAN11_THREAD FOR LARGER COMBINATIONS  HAS SUCCEEDED LARGE  SCORE THAN  " + h12.ToString() + " FROM  HISTORY_7..FOR COMBINATION.  " + h3[1, 0].ToString() + "  " + h3[1, 1].ToString() + "  " + h3[1, 2].ToString() + "  " + h3[1, 3].ToString() + "  " + h3[1, 4].ToString() + "  " + h3[1, 5].ToString() + "  " + h3[1, 6].ToString() + "  " + h3[1, 7].ToString() + "  ");

                            h12 = 0;

                        }
                        h12 = 0;


                        if ((h3[1, d33] < 39))
                        {
                            h3[1, d33] = h3[1, d33] + 1;
                            goto loop10;
                        }
                        if (h20 != 1)
                        {
                            h3[1, d33] = 1;
                            // goto loop1;
                        }
                        else
                            break;
                        loop10:

                    // term_flag = 1;
                    //if (h3[1, 0] == 1)
                    // { h3[1, 0] = h3[1, 0] + 1;
                    loop2:
                        //   }
                        switch (d33)
                        {
                            case 0:
                                if ((h3[1, d33] != h3[1, 1] && h3[1, d33] != h3[1, 2] && h3[1, d33] != h3[1, 3] && h3[1, d33] != h3[1, 4] && h3[1, d33] != h3[1, 5] && h3[1, d33] != h3[1, 6] && h3[1, d33] != h3[1, 7]))
                                {
                                    // h3[1, 0] = h3[1, 0] + 2;
                                    if (h3[1, d33] == h20)
                                        goto default;
                                    if ((h3[1, d33] < 40))
                                        goto loop1;
                                    if (h20 != 1)
                                    {
                                        h3[1, d33] = 1;
                                        goto loop1;
                                    }
                                    else
                                        goto default;

                                }

                                h3[1, d33] = h3[1, d33] + 1;
                                goto loop2;



                            case 1:
                                if ((h3[1, d33] != h3[1, 0] && h3[1, d33] != h3[1, 2] && h3[1, d33] != h3[1, 3] && h3[1, d33] != h3[1, 4] && h3[1, d33] != h3[1, 5] && h3[1, d33] != h3[1, 6] && h3[1, d33] != h3[1, 7]))
                                {
                                    // h3[1, 0] = h3[1, 0] + 2;
                                    if (h3[1, d33] == h20)
                                        goto default;
                                    if ((h3[1, d33] < 40))
                                        goto loop1;
                                    if (h20 != 1)
                                    {
                                        h3[1, d33] = 1;
                                        goto loop1;
                                    }
                                    else
                                        goto default;

                                }
                                h3[1, d33] = h3[1, d33] + 1;
                                goto loop2;

                            case 2:
                                if ((h3[1, d33] != h3[1, 1] && h3[1, d33] != h3[1, 0] && h3[1, d33] != h3[1, 3] && h3[1, d33] != h3[1, 4] && h3[1, d33] != h3[1, 5] && h3[1, d33] != h3[1, 6] && h3[1, d33] != h3[1, 7]))
                                {
                                    // h3[1, 0] = h3[1, 0] + 2;
                                    if (h3[1, d33] == h20)
                                        goto default;
                                    if ((h3[1, d33] < 40))
                                        goto loop1;
                                    if (h20 != 1)
                                    {
                                        h3[1, d33] = 1;
                                        goto loop1;
                                    }
                                    else
                                        goto default;

                                }
                                h3[1, d33] = h3[1, d33] + 1;
                                goto loop2;

                            case 3:
                                if ((h3[1, d33] != h3[1, 1] && h3[1, d33] != h3[1, 2] && h3[1, d33] != h3[1, 0] && h3[1, d33] != h3[1, 4] && h3[1, d33] != h3[1, 5] && h3[1, d33] != h3[1, 6] && h3[1, d33] != h3[1, 7]))
                                {
                                    // h3[1, 0] = h3[1, 0] + 2;
                                    if (h3[1, d33] == h20)
                                        goto default;
                                    if ((h3[1, d33] < 40))
                                        goto loop1;
                                    if (h20 != 1)
                                    {
                                        h3[1, d33] = 1;
                                        goto loop1;
                                    }
                                    else
                                        goto default;

                                }
                                h3[1, d33] = h3[1, d33] + 1;
                                goto loop2;

                            case 4:
                                if ((h3[1, d33] != h3[1, 1] && h3[1, d33] != h3[1, 2] && h3[1, d33] != h3[1, 3] && h3[1, d33] != h3[1, 0] && h3[1, d33] != h3[1, 5] && h3[1, d33] != h3[1, 6] && h3[1, d33] != h3[1, 7]))
                                {
                                    // h3[1, 0] = h3[1, 0] + 2;
                                    if (h3[1, d33] == h20)
                                        goto default;
                                    if ((h3[1, d33] < 40))
                                        goto loop1;
                                    if (h20 != 1)
                                    {
                                        h3[1, d33] = 1;
                                        goto loop1;
                                    }
                                    else
                                        goto default;

                                }
                                h3[1, d33] = h3[1, d33] + 1;
                                goto loop2;

                            case 5:
                                if ((h3[1, d33] != h3[1, 1] && h3[1, d33] != h3[1, 2] && h3[1, d33] != h3[1, 3] && h3[1, d33] != h3[1, 4] && h3[1, d33] != h3[1, 0] && h3[1, d33] != h3[1, 6] && h3[1, d33] != h3[1, 7]))
                                {
                                    // h3[1, 0] = h3[1, 0] + 2;
                                    if (h3[1, d33] == h20)
                                        goto default;
                                    if ((h3[1, d33] < 40))
                                        goto loop1;
                                    if (h20 != 1)
                                    {
                                        h3[1, d33] = 1;
                                        goto loop1;
                                    }
                                    else
                                        goto default;

                                }
                                h3[1, d33] = h3[1, d33] + 1;
                                goto loop2;

                            case 6:
                                if ((h3[1, d33] != h3[1, 1] && h3[1, d33] != h3[1, 2] && h3[1, d33] != h3[1, 3] && h3[1, d33] != h3[1, 4] && h3[1, d33] != h3[1, 5] && h3[1, d33] != h3[1, 0] && h3[1, d33] != h3[1, 7]))
                                {
                                    // h3[1, 0] = h3[1, 0] + 2;
                                    if (h3[1, d33] == h20)
                                        goto default;
                                    if ((h3[1, d33] < 40))
                                        goto loop1;
                                    if (h20 != 1)
                                    {
                                        h3[1, d33] = 1;
                                        goto loop1;
                                    }
                                    else
                                        goto default;

                                }
                                h3[1, d33] = h3[1, d33] + 1;
                                goto loop2;

                            case 7:
                                if ((h3[1, d33] != h3[1, 1] && h3[1, d33] != h3[1, 2] && h3[1, d33] != h3[1, 3] && h3[1, d33] != h3[1, 4] && h3[1, d33] != h3[1, 5] && h3[1, d33] != h3[1, 6] && h3[1, d33] != h3[1, 0]))
                                {
                                    // h3[1, 0] = h3[1, 0] + 2;
                                    if (h3[1, d33] == h20)
                                        goto default;
                                    if ((h3[1, d33] < 40))
                                        goto loop1;
                                    if (h20 != 1)
                                    {
                                        h3[1, d33] = 1;
                                        goto loop1;
                                    }
                                    else
                                        goto default;

                                }
                                h3[1, d33] = h3[1, d33] + 1;
                                goto loop2;

                            default:
                                break;


                        }






                    }


                    if (error == 1)
                    {
                        error = 0;
                        break;
                    }

                    n++;
                    //  lock (this)
                    // {
                    cnt19--;


                    if (cnt19 <= 0)//first level  check comb
                    {
                        cnt1919--;//second level  check comb
                        if (cnt1919 <= 0)
                            goto loop5;

                    }

                loop5:
                    if (cnt1919 <= 0)
                    {
                        cnt191919--;//third level  check comb
                        if (cnt191919 <= 0)
                            goto loop6;
                    }
                // cnt19--;first level comb
                //cnt1919--;second level comb
                // cnt191919--;third level comb

                loop6:

                    cnt191++;
                }
                //   }

            } while (cnt191919 > 0 || h3[1, 1] == 0 || h3[1, 2] == 0 || h3[1, 3] == 0 || h3[1, 4] == 0 || h3[1, 5] == 0 || h3[1, 6] == 0 || h3[1, 0] == 0);


            MessageBox.Show("END_OF_AUTO_SCAN11_THREAD....FOR_ALL_FLAG_NUMS_NUMBER_ALL_LAST MAX COMBINATIONS.  " + cnt191.ToString() + "  FROM HISTORY_7 WITH MAX SCORE  ." + h18.ToString() + "  ");

            new Thread(new ThreadStart(stat_auto_scan2)).Start();
        }

        //NEW START_AUTO_SCAN6





        public void stat_auto_scan2()
          {

               MessageBox.Show("START_AUTO_SCAN2_THREAD....STARTED....LAST COMBINATION   WAS EXTRACTED FROM HISTORY AND IS UNDER PROCESSING..", draws.Count.ToString());
               // str:
               //  for (sas = 100000000; sas > -1000000000; --sas)
               ///  { for (sas1 = 100000000; sas1 > -1000000000; --sas1) ;
               //      
               //       }
               //goto str;
               //++sas;
               //add_history_7();
                
               MessageBox.Show("END_OF_AUTO_SCAN2_THREAD....FOR_FIRST_NUMBER_ALL_COMBINATIONS.  "  );

          }







          public void stat_auto_scan()
        {
              // int gm = 0;
               if (dm1 == 1)
                    MessageBox.Show("data mine is enabled");










               else if (dm1 == 0)


                    MessageBox.Show("data mine is disabled");
              

               // int[] maxAutotemp15 ={ 1, 5, 6, 9, 13, 14, 16, 20, 32, 33, 35, 37, 39, 40, 44 };
               // int[] startAuto15 ={ 1, 5, 6, 9, 13, 14, 16, 20, 32, 33, 35, 37, 39, 40, 44 };
               
            {
                    
                    

                for (int f40 = 0; f40 < flag_num; f40++)
                {
                    startAuto151[f40] = maxAutotemp15[f40];
                    startAuto15[f40] = startAuto151[f40];
                    startAuto16[f40] = startAuto151[f40];

                }
                string output1 = " ";
                string output2 = " ";
                txtResults2.Text = output2;
                txtResults.Text = output1;

                if (f18 == 1)
                {
                    fill_list();
                    f18 = 0;
                }
                repflag = 1;
                f14 = 0;
                f12 = 0;
                loopflag = 0;
                //start  future  loop
                MessageBox.Show("START  of auto scan");

                    do
                    {
                         loopflag++;
                         textBox18.Text = loopflag.ToString();

                         repflag2 = 0;



                         /*

                              for (ll2 = 0; ll2 < 0; ll2++)
                              {
                                  ll1 = winrandom3from15.Next(0, 15);


                                  startAuto15[ll1] = winrandom15from45.Next(1, 46);

                                  do
                                  {
                                      ll4=0;
                                      for (ll3 = 0; ll3 < 15; ll3++)
                                      {

                                          if (ll3 != ll1)
                                          {
                                              if (startAuto15[ll3] == startAuto15[ll1])
                                              {
                                                  startAuto15[ll1] = winrandom15from45.Next(1, 46);nbm
                                                  ll4 = 1;
                                              }
                                          }
                                      }
                                   } while (ll4 == 1);

                              }



                          */





                         /*



                                             for (int f30 = 0; f30 < 15; f30++)
                                             {

                                                   //startAuto15[f30] = winrandom15from45.Next(1, 46);

                                                if(f30!=0)
                                                 {
                                                     do
                                                     {
                                                         repflag = 0;
                                                         for (n = 0; n < f30; n++)
                                                         {

                                                                 if (startAuto15[n] == startAuto15[f30])
                                                                 {
                                                                     startAuto15[f30] = winrandom15from45.Next(1, 46);
                                                                     repflag = 1;
                                                                 }


                                                         }
                                                     } while (repflag != 0);

                                             }
                                             }

                  */

                         /*
                        {
                            for (int f30 = 5; f30 < 15; f30++)
                            {

                                 startAuto15[f30] = winrandom15from45.Next(1, 46);


                                    do
                                    {
                                        repflag = 0;
                                        for (n = 0; n < 15; n++)
                                        {
                                            if (n != f30)
                                            {
                                                if (startAuto15[n] == startAuto15[f30])
                                                {
                                                    startAuto15[f30] = winrandom15from45.Next(1, 46);
                                                    repflag = 1;
                                                }
                                            }

                                        }
                                    } while (repflag != 0);


                            }
                        }



                    */



                         do
                         {
                              repflag2++;



                              //  if (endflag == 1)
                              //   break;(f30!=
                              for (int f21 = 0; f21 < flag_num; f21++)
                              {


                                   frep = 0;
                                   do
                                   {



                                        do
                                        {
                                             //MessageBox.Show("Inside1 nbm loop");

                                             if (nbm_loop_count > 1)
                                             {
                                                  // MessageBox.Show("Inside2 nbm loop");

                                                  for (int f40 = 0; f40 < flag_num; f40++)
                                                  {
                                                       startAuto151[f40] = tempStartAuto15[nbm_loop_count, f40];
                                                       // startAuto16[f40] = startAuto151[f40];

                                                  }
                                                  nbm_loop_count--;
                                                  if (nbm_loop_count == 1)
                                                       nbm_flag = 0;

                                             }
                                             lock(this)
                                             { 
                                             for (f12 = 0; f12 < draws.Count; f12++)
                                             {
                                                  for (f42 = 0; f42 < flag_num; f42++)
                                                  {
                                                       del2temp15[f42] = del15[f42];
                                                  }


                                                  for (c3 = 0; c3 < flag_num; c3++)
                                                  {

                                                       if (startAuto151[c3] == draws[f12].num1 || startAuto151[c3] == draws[f12].num2 || startAuto151[c3] == draws[f12].num3 || startAuto151[c3] == draws[f12].num4 || startAuto151[c3] == draws[f12].num5)
                                                       {
                                                            f16++;

                                                            del15[c3] = 0;//if hit  a number is reset to 0 in the  win5
                                                            numtemp15[c3]++;//counts  the  times a number is hit  in the  win5
                                                       }
                                                       else
                                                            del15[c3]++;//counts  the  times a number is not  hit

                                                  }

                                                  /*   if (((f16 >= win_cnt) && (nbm_loop_count==1))||((f16>=win_cnt) && (c3==0)&&((nbm_loop_count==2)||(nbm_loop_count==3))) ||

                                                    ((f16>=win_cnt) && (c3 == 1) && ((nbm_loop_count == 4) || (nbm_loop_count == 5))) || ((f16>=win_cnt) && (c3==2) && ((nbm_loop_count==6)||(nbm_loop_count==7)))
                                                  || ((f16>=win_cnt)  && (c3==3)&&((nbm_loop_count==8)||(nbm_loop_count==9))) || ((f16>=win_cnt) && (c3==4)&&((nbm_loop_count==10)||(nbm_loop_count==11)))

                                                || ((f16 >= win_cnt) && (c3 == 5) && ((nbm_loop_count == 12) || (nbm_loop_count == 13))))  */

                                                  if ((f16 >= win_cnt) && (lock_count_flag == 0) || (f16 >= win_cnt) && (lock_count_flag == 1) && (f22 < (int)numericUpDown17.Value))

                                                  //modification not  to include     4 winners
                                                  //if ((f16 > 4)||(f16==4))//modification to include also   4 winners
                                                  {
                                                       for (f42 = 0; f42 < flag_num; f42++)
                                                       {
                                                            deltemp15[f42] = del2temp15[f42];
                                                            winnum15[f42] = startAuto151[f42];
                                                            num15[f42] += numtemp15[f42];//transfer the hit numbers  to display array
                                                       }
                                                       f16 = 0;
                                                       f22++;
                                                       //  if(f22>17)
                                                       //  MessageBox.Show("hi   from >17 auto scan");
                                                       output1 += draws[f12].date2.ToString() + " " + draws[f12].num1.ToString() + " " + draws[f12].num2.ToString() + " " + draws[f12].num3.ToString() + " " + draws[f12].num4.ToString() + " " + draws[f12].num5.ToString() + "       " + draws[f12].joker.ToString() + "\n";

                                                       win5temp[f22, 0] = draws[f12].num1;
                                                       win5temp[f22, 1] = draws[f12].num2;
                                                       win5temp[f22, 2] = draws[f12].num3;
                                                       win5temp[f22, 3] = draws[f12].num4;
                                                       win5temp[f22, 4] = draws[f12].num5;
                                                       //C22++;



                                                  }

                                                  for (f41 = 0; f41 < flag_num; f41++)
                                                  {
                                                       //deltemp15[f41] = del15[f41];
                                                       numtemp15[f41] = 0;//zero temporary  array
                                                  }
                                                  f16 = 0;

                                             }
                                        }


                                             if ((nbm_flag == 1) && (nbm_flag_man == 1) && (f22 > 6))
                                             {
                                                  if (nbm_num1_flag == 1)
                                                  {
                                                       nbm_num_array[0, 0] = (int)numericUpDown1.Value;
                                                       nbm_num_array[0, 1] = (int)numericUpDown2.Value;

                                                  }

                                                  if (nbm_num2_flag == 1)
                                                  {
                                                       nbm_num_array[1, 0] = (int)numericUpDown3.Value;
                                                       nbm_num_array[1, 1] = (int)numericUpDown4.Value;



                                                  }

                                                  if (nbm_num3_flag == 1)
                                                  {

                                                       nbm_num_array[2, 0] = (int)numericUpDown5.Value;
                                                       nbm_num_array[2, 1] = (int)numericUpDown6.Value;


                                                  }

                                                  if (nbm_num4_flag == 1)
                                                  {
                                                       nbm_num_array[3, 0] = (int)numericUpDown7.Value;
                                                       nbm_num_array[3, 1] = (int)numericUpDown8.Value;



                                                  }

                                                  if (nbm_num5_flag == 1)
                                                  {
                                                       nbm_num_array[4, 0] = (int)numericUpDown9.Value;
                                                       nbm_num_array[4, 1] = (int)numericUpDown10.Value;



                                                  }

                                                  if (nbm_num6_flag == 1)
                                                  {
                                                       nbm_num_array[5, 0] = (int)numericUpDown13.Value;
                                                       nbm_num_array[5, 1] = (int)numericUpDown14.Value;



                                                  }



                                                  for (int nbm1 = 0; nbm1 < 6; nbm1++)
                                                  {
                                                       for (int nbm2 = 0; nbm2 < 2; nbm2++)
                                                       {
                                                            int nbm3 = nbm_num_array[nbm1, nbm2];
                                                            if (nbm3 == 0)
                                                                 nbm4 = 0;
                                                            else
                                                                 nbm4 = 1;                              //check  if any value set for neighbouring..if not  exit loop
                                                            nbm5 += nbm4;
                                                            nbm3 = 0;

                                                       }
                                                  }


                                             }
                                             else

                                                 if ((nbm_flag == 1) && (nbm_flag_auto == 1) && (f22 > 6) && (nbm_loop_count == 1))
                                             {
                                                  MessageBox.Show("CURRENT  NBM MODE IS STARTED");

                                                  nbm_delta_total = (int)numericUpDown11.Value;
                                                  nbm_num_count = (int)numericUpDown12.Value;
                                                  nbm_count_flag++;
                                                  nbm_mode_flag = 1;
                                                  nbm_mode_adjust();
                                             }






                                             /*

                                             if (nbm_flag == 1 && f22 != 0 && nbm5 != 0)
                                             {
                                                 if (nbm_num_array[2, 0] == 2)
                                                 {
                                                     if (startAuto15[3] - startAuto15[2] > 2)
                                                     {
                                                         startAuto15[2]++;
                                                         startAuto15[2]++;
                                                     }
                                                     {
                                                         nbm_num3_flag = 0;
                                                         nbm_num_array[2, 0] = 0;
                                                         nbm5 = 0; nbm4 = 0;
                                                     }
                                                 }




                                             }   */





                                             //  } while (nbm_flag == 1 && f22!=0 && nbm5!=0);

                                        } while (nbm_flag == 1 && f22 != 0);

                                        if (nbm_mode_flag != 0)
                                        {
                                             MessageBox.Show("CURRENT  NBM MODE IS TERMINATED");
                                             nbm_mode_flag = 0;
                                             nbm_flag = 0;
                                        }
                                        nbm5 = 0;
                                        nbm4 = 0;



                                        output1 += startAuto151[14].ToString() + "      " + startAuto151[13].ToString() + "      " + startAuto151[12].ToString() + "      " + startAuto151[11].ToString() + "      " + startAuto151[10].ToString() + "      " + startAuto151[9].ToString() + "       " + startAuto151[8].ToString() + "       " + startAuto151[7].ToString() + "       " + startAuto151[6].ToString() + "       " + startAuto151[5].ToString() + "       " + startAuto151[4].ToString() + "       " + startAuto151[3].ToString() + "       " + startAuto151[2].ToString() + "       " + startAuto151[1].ToString() + "       " + startAuto151[0].ToString() + "\n";
                                        output1 += deltemp15[14].ToString() + "      " + deltemp15[13].ToString() + "      " + deltemp15[12].ToString() + "      " + deltemp15[11].ToString() + "      " + deltemp15[10].ToString() + "      " + deltemp15[9].ToString() + "      " + deltemp15[8].ToString() + "      " + deltemp15[7].ToString() + "      " + deltemp15[6].ToString() + "      " + deltemp15[5].ToString() + "      " + deltemp15[4].ToString() + "      " + deltemp15[3].ToString() + "      " + deltemp15[2].ToString() + "      " + deltemp15[1].ToString() + "      " + deltemp15[0].ToString() + "\n";

                                        //txtResults2.Text = "  ";
                                        for (int out2 = 0; out2 < flag_num; out2++)
                                        {

                                             output2 += startAuto151[out2].ToString() + "      ";
                                        }
                                        output2 += Convert.ToString(f22) + "\n";






                                        for (f41 = 0; f41 < flag_num; f41++)
                                        {
                                             del2temp15[f41] = 0;
                                             del15[f41] = 0;
                                             deltemp15[f41] = 0;
                                             numpar15[f41] = num15[f41];
                                             num15[f41] = 0; //zero  display  array
                                        }





                                        f23 = f22;

                                //if (f22 >= Convert.ToInt32(textBox16.Text) || loopflag == 5 || loopflag == 8 || loopflag == 11 || loopflag == 14 || loopflag == 17 || loopflag == 20 || loopflag == 23 || loopflag == 26 || loopflag == 29 || loopflag == 32 || loopflag == 35 || loopflag == 38 || loopflag == 41 || loopflag == 45 || loopflag == 48 || loopflag == 51)

                                if (f22 >= Convert.ToInt32(textBox16.Text))



                                // if (f22 >= Convert.ToInt32(textBox16.Text) || loopflag == 5 || loopflag == 8 || loopflag == 11 || loopflag == 14 || loopflag == 17 || loopflag == 20 || loopflag == 23 || loopflag == 26 || loopflag == 29 || loopflag == 32 || loopflag == 35 || loopflag == 38 || loopflag == 41 || loopflag == 45 || loopflag == 48 || loopflag == 51 || loopflag == 54 || loopflag == 57 || loopflag == 60 || loopflag == 63)
                                {
                                    if (f22 > Convert.ToInt32(textBox16.Text))
                                    {
                                        lock (this)
                                        {

                                            cnt191919 = cnt1919;//third level
                                            cnt1919 = cnt19;//second level


                                            cnt19 = 1; //first level
                                        }
                                    }

                                    if (f22 == Convert.ToInt32(textBox16.Text))
                                    {

                                        lock (this)
                                        {
                                            cnt19++;
                                        }
                                    }

                                    tempf61 = f61;
                                    tempf21 = f21;
                                    tempif21 = startAuto151[f21];
                                    tempif61 = startAuto151[f61];
                                    winflag = 1;
                                    for (f32 = 0; f32 < 5; f32++)
                                    {
                                        for (f31 = 0; f31 < 300; f31++)
                                        {
                                            win5[f31, f32] = win5temp[f31, f32];

                                        }
                                    }
                                    f23 = f22;
                                    f22temp = f22;//stores   temporarily  f22 for access in predict method

                                    textBox16.Text = Convert.ToString(0);

                                    textBox16.Text = Convert.ToString(f22);


                                    // MessageBox.Show("LEARNING MODE STARTED.1..... ");
                                    // txtResults.Text = "LEARNING MODE STARTED...... ";
                                    //MessageBox.Show("LEARNING MODE STARTED.2..... ");
                                    //txtResults2.Text = "  ";

                                    txtResults.Text = output1;

                                    if (Convert.ToInt32(textBox16.Text) >= Convert.ToInt32(textBox21.Text))
                                    {



                                        C22++;
                                        txtResults2.Text += output2;
                                        txtResults2.Text += " ";
                                        txtResults2.Text += Convert.ToString(C22);
                                        txtResults2.Text += " ";
                                        textBox19.Text = Convert.ToString(C22);
                                        add_history_7();
                                        lock (this)
                                        {
                                            adhi++;
                                        }
                                        string message1 = "PLEASE CHECK HISTORY_7 ARRAY.....HERE WE HAVE TO CREATE NEW THREADS AS THE ARRAYS ITEMS NUMBER SCAN1,SCAN2 AS TESTING THIS MODE OF OPERATION.... ......DO YOU WANT TO CONTINUE THIS  THREAD MODE  OR PROCEED AS NORMAL?";
                                        string title = "ENABLE  THREAD MODE";
                                        MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;


                                        if (C22 == 3)
                                        { 
                                        // { MessageBox.Show("PLEASE CHECK HISTORY_7 ARRAY.....HERE WE HAVE TO CREATE NEW THREADS AS THE ARRAYS ITEMS  NUMBER SCAN1,SCAN2 AS TESTING THIS MODE OF OPERATION.... "); 
                                        //  new Thread(new ThreadStart(stat_auto_scan1)).Start();
                                        //   new Thread(new ThreadStart(stat_auto_scan2)).Start();

                                        // MessageBox.Show("START_AUTO_SCAN5   STARTED", Convert.ToString(sas) + "  " + Convert.ToString(sas1));
                                        //  }


                                        DialogResult result = MessageBox.Show(message1, title, buttons, MessageBoxIcon.Warning);
                                        if (result == DialogResult.Yes)
                                        {
                                            new Thread(new ThreadStart(stat_auto_scan1)).Start();


                                                


                                                // Do nothing  
                                            }
                                        else
 if (result == DialogResult.No)
                                            {


new Thread(new ThreadStart(stat_auto_scan11)).Start();
                                            }
                                        else
if (result == DialogResult.Cancel)
                                            {

                                                MessageBox.Show("Continuation of Normal operation has been selected");
                                            }


                                    }
                                }   // Do something  
                                        



                                        //  if (C22 >= 4)
                                        // MessageBox.Show("PLEASE CHECK HISTORY_7 ARRAY.....HERE WE HAVE TO SIMULATE PROCESSING  THE  NEW THREADS", Convert.ToString(sas)+"    "+Convert.ToString(sas1));

                                    



                                             for (int a1 = 0; a1 < flag_num; a1++)
                                             {
                                                  winnumfinal15[a1] = winnum15[a1];
                                                  winnum15[a1] = 0;

                                             }

                                        }
                                        output2 = "";
                                        output1 = "";

                                        f22 = 0;
                                        start_again:
                                        //int f61 = 0;
                                        int c2 = 1;
                                        int c1 = 0;
                                        if (flag_num == 15)
                                        {
                                             sm3 = 14;
                                             f61 = num15smaller();


                                        }
                                        else
                                            if (flag_num == 8)
                                        {
                                             sm8 = 7;
                                             f61 = num8smaller();
                                        }
                                        else
                                                if (flag_num == 7)
                                        {
                                             sm8 = 6;
                                             f61 = num7smaller();

                                        }

                                        else
                                                    if (flag_num == 9)
                                        {
                                             sm8 = 8;
                                             f61 = num9smaller();

                                        }

                                        else
                                                        if (flag_num == 10)
                                        {
                                             sm8 = 9;
                                             f61 = num10smaller();

                                        }

                                        else
                                                            if (flag_num == 6)
                                        {
                                             sm8 = 5;
                                             f61 = num6smaller();

                                        }
                                        else
                                                            if (flag_num == 5)
                                        {
                                             sm8 = 4;
                                             f61 = num5smaller();

                                        }




                                        startAuto151[f61] = winrandom.Next(1, 39);
                                        if (f61 == f21)
                                        {

                                             if (f61 == 0)
                                                  f61 = f61 + 1;
                                             else
                                                 if (((flag_num == 15) && (f61 == 14)) || ((flag_num == 8) && (f61 == 7)) || ((flag_num == 7) && (f61 == 6)) || ((flag_num == 10) && (f61 == 9) || ((flag_num == 9) && (f61 == 8) || ((flag_num == 6) && (f61 == 5)) || ((flag_num == 5) && (f61 == 4)))))
                                                  f61 = f61 - 1;//fake larger





                                             else
                                                     if (((flag_num == 15) && (f61 > 0 && f61 < 14)) || ((flag_num == 8) && (f61 > 0 && f61 < 7)) || ((flag_num == 7) && (f61 > 0 && f61 < 6)) || ((flag_num == 9) && (f61 > 0 && f61 < 8)) || ((flag_num == 10) && (f61 > 0 && f61 < 9)) || ((flag_num == 6) && (f61 > 0 && f61 < 5)))
                                                  f61 = f61 + 1;

                                             startAuto151[f61] = winrandom.Next(1, 39);
                                        }



                                        //f61 = 14; 
                                        /*  
                                        do
                                        {
                                            f61 = winrandom3from15.Next(0, 15);
                                        } while (f61 == f21);

                                         */

                                        c2 = 1;
                                        c3 = 1;
                                        frep++;
                                        startflag = 0;
                                        //while (c2!=0)

                                        while ((c2 != 0) || (c3 != 0))
                                        {



                                             // f61 = f21;
                                             //if (startflag==0)
                                             if (startflag == 0 || c2 == 1)
                                             {
                                                  //startAuto15[f21] = winrandom.Next(1, 46);
                                                  if (f21 != f61)
                                                  {
                                                       do
                                                       {
                                                            startAuto151[f21] = winrandom.Next(1, 39);
                                                       } while (startAuto151[f21] == startAuto151[f61] || startAuto151[f21] == tempif61 || startAuto151[f21] == tempif21);

                                                  }

                                             }


                                             //if (startflag==0)

                                             if (startflag == 0 || c3 == 1)
                                             {

                                                  if (f21 != f61)
                                                  {
                                                       do
                                                       {
                                                            startAuto151[f61] = winrandom.Next(1, 39);
                                                       } while (startAuto151[f61] == startAuto151[f21] || startAuto151[f61] == tempif21 || startAuto151[f61] == tempif61);
                                                       //} while(startAuto15[f61] == startAuto15[1]||startAuto15[f61] == startAuto15[0]||startAuto15[f61] == startAuto15[2]||startAuto15[f61] == startAuto15[3]||startAuto15[f61] == startAuto15[4]||startAuto15[f61] == startAuto15[5]||startAuto15[f61] == startAuto15[6]||startAuto15[f61] == startAuto15[7]||startAuto15[f61] == startAuto15[8]||startAuto15[f61] == startAuto15[9]||startAuto15[f61] == startAuto15[10]||startAuto15[f61] == startAuto15[11]||startAuto15[f61] == startAuto15[12]||startAuto15[f61] == startAuto15[13]||startAuto15[f61]==tempif21);

                                                  }

                                             }


                                             //  startAuto15[f21]++;
                                             //if   ( startAuto15[0]!=

                                             c3 = 0;
                                             c2 = 0;
                                             if (flag_num == 15)
                                             {

                                                  switch (f21)
                                                  {

                                                       case 0:
                                                            for (c1 = 1; c1 < 15; c1++)//check values>[f21] i.e if  f21=6   it checks the array positions 7,8,9,10,11,12,13,14  
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;



                                                       case 1:
                                                            for (c1 = 1; c1 < 14; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 1; c1++)//check values<[f21]  i.e if f21= 6   it checks the array positions   5,4,3,2,1,0
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;

                                                       case 2:
                                                            for (c1 = 1; c1 < 13; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;


                                                       case 3:
                                                            for (c1 = 1; c1 < 12; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }
                                                            break;

                                                       case 4:
                                                            for (c1 = 1; c1 < 11; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;

                                                       case 5:
                                                            for (c1 = 1; c1 < 10; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }
                                                            break;

                                                       case 6:
                                                            for (c1 = 1; c1 < 9; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;

                                                       case 7:

                                                            for (c1 = 1; c1 < 8; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 7; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;
                                                       case 8:
                                                            for (c1 = 1; c1 < 7; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 8; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;

                                                       case 9:
                                                            for (c1 = 1; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 9; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }


                                                            break;


                                                       case 10:

                                                            for (c1 = 1; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 10; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;

                                                       case 11:

                                                            for (c1 = 1; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }

                                                            for (c1 = 0; c1 < 11; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }


                                                            break;
                                                       case 12:

                                                            for (c1 = 1; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 12; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }




                                                            break;
                                                       case 13:
                                                            for (c1 = 1; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 13; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }


                                                            break;

                                                       case 14:


                                                            for (c1 = 0; c1 < 14; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }





                                                            break;

                                                       default:
                                                            c2 = 1;
                                                            break;


                                                  }//end  first switch



                                                  switch (f61)
                                                  {

                                                       case 0:
                                                            for (c1 = 1; c1 < 15; c1++)//check values>[f21] i.e if  f21=6   it checks the array positions 7,8,9,10,11,12,13,14  
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;



                                                       case 1:
                                                            for (c1 = 1; c1 < 14; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 1; c1++)//check values<[f21]  i.e if f21= 6   it checks the array positions   5,4,3,2,1,0
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;
                                                       case 2:
                                                            for (c1 = 1; c1 < 13; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;



                                                       case 3:
                                                            for (c1 = 1; c1 < 12; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }
                                                            break;


                                                       case 4:
                                                            for (c1 = 1; c1 < 11; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;

                                                       case 5:
                                                            for (c1 = 1; c1 < 10; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }
                                                            break;

                                                       case 6:
                                                            for (c1 = 1; c1 < 9; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;

                                                       case 7:

                                                            for (c1 = 1; c1 < 8; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 7; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;
                                                       case 8:
                                                            for (c1 = 1; c1 < 7; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 8; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;

                                                       case 9:
                                                            for (c1 = 1; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 9; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }


                                                            break;


                                                       case 10:

                                                            for (c1 = 1; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 10; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }


                                                            break;
                                                       case 11:

                                                            for (c1 = 1; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }

                                                            for (c1 = 0; c1 < 11; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }


                                                            break;
                                                       case 12:

                                                            for (c1 = 1; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 12; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }




                                                            break;
                                                       case 13:
                                                            for (c1 = 1; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 13; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }


                                                            break;

                                                       case 14:


                                                            for (c1 = 0; c1 < 14; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }





                                                            break;

                                                       default:
                                                            c3 = 1;
                                                            break;


                                                  }//end  second switch


                                             }//end  first if


                                             else
                                                 if (flag_num == 8)
                                             {


                                                  switch (f21)
                                                  {

                                                       case 0:
                                                            for (c1 = 1; c1 < 8; c1++)//check values>[f21] i.e if  f21=6   it checks the array positions 7,8,9,10,11,12,13,14  
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;



                                                       case 1:
                                                            for (c1 = 1; c1 < 7; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 1; c1++)//check values<[f21]  i.e if f21= 6   it checks the array positions   5,4,3,2,1,0
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;

                                                       case 2:
                                                            for (c1 = 1; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;


                                                       case 3:
                                                            for (c1 = 1; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }
                                                            break;

                                                       case 4:
                                                            for (c1 = 1; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;

                                                       case 5:
                                                            for (c1 = 1; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }
                                                            break;

                                                       case 6:
                                                            for (c1 = 1; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;









                                                       case 7:


                                                            for (c1 = 0; c1 < 7; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }





                                                            break;

                                                       default:
                                                            c2 = 1;
                                                            break;


                                                  }//end  first switch



                                                  switch (f61)
                                                  {

                                                       case 0:
                                                            for (c1 = 1; c1 < 8; c1++)//check values>[f21] i.e if  f21=6   it checks the array positions 7,8,9,10,11,12,13,14  
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;



                                                       case 1:
                                                            for (c1 = 1; c1 < 7; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 1; c1++)//check values<[f21]  i.e if f21= 6   it checks the array positions   5,4,3,2,1,0
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;
                                                       case 2:
                                                            for (c1 = 1; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;



                                                       case 3:
                                                            for (c1 = 1; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }
                                                            break;


                                                       case 4:
                                                            for (c1 = 1; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;

                                                       case 5:
                                                            for (c1 = 1; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }
                                                            break;

                                                       case 6:
                                                            for (c1 = 1; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;











                                                       case 7:


                                                            for (c1 = 0; c1 < 7; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }





                                                            break;

                                                       default:
                                                            c3 = 1;
                                                            break;


                                                  }//end  second switch






                                             }//end here




                                             else
                                                     if (flag_num == 7)
                                             {


                                                  switch (f21)
                                                  {

                                                       case 0:
                                                            for (c1 = 1; c1 < 7; c1++)//check values>[f21] i.e if  f21=6   it checks the array positions 7,8,9,10,11,12,13,14  
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;



                                                       case 1:
                                                            for (c1 = 1; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 1; c1++)//check values<[f21]  i.e if f21= 6   it checks the array positions   5,4,3,2,1,0
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;

                                                       case 2:
                                                            for (c1 = 1; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;


                                                       case 3:
                                                            for (c1 = 1; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }
                                                            break;

                                                       case 4:
                                                            for (c1 = 1; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;

                                                       case 5:
                                                            for (c1 = 1; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }
                                                            break;











                                                       case 6:


                                                            for (c1 = 0; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }





                                                            break;

                                                       default:
                                                            c2 = 1;
                                                            break;


                                                  }//end  first switch



                                                  switch (f61)
                                                  {

                                                       case 0:
                                                            for (c1 = 1; c1 < 7; c1++)//check values>[f21] i.e if  f21=6   it checks the array positions 7,8,9,10,11,12,13,14  
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;



                                                       case 1:
                                                            for (c1 = 1; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 1; c1++)//check values<[f21]  i.e if f21= 6   it checks the array positions   5,4,3,2,1,0
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;
                                                       case 2:
                                                            for (c1 = 1; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;



                                                       case 3:
                                                            for (c1 = 1; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }
                                                            break;


                                                       case 4:
                                                            for (c1 = 1; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;

                                                       case 5:
                                                            for (c1 = 1; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }
                                                            break;













                                                       case 6:


                                                            for (c1 = 0; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }





                                                            break;

                                                       default:
                                                            c3 = 1;
                                                            break;















                                                  }//end  second switch






                                             }//end here



                                             else
                                                         if (flag_num == 9)
                                             {


                                                  switch (f21)
                                                  {

                                                       case 0:
                                                            for (c1 = 1; c1 < 9; c1++)//check values>[f21] i.e if  f21=6   it checks the array positions 7,8,9,10,11,12,13,14  
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;



                                                       case 1:
                                                            for (c1 = 1; c1 < 8; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 1; c1++)//check values<[f21]  i.e if f21= 6   it checks the array positions   5,4,3,2,1,0
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;

                                                       case 2:
                                                            for (c1 = 1; c1 < 7; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;


                                                       case 3:
                                                            for (c1 = 1; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }
                                                            break;

                                                       case 4:
                                                            for (c1 = 1; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;

                                                       case 5:
                                                            for (c1 = 1; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }
                                                            break;

                                                       case 6:
                                                            for (c1 = 1; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;


                                                       case 7:
                                                            for (c1 = 1; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 7; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;






                                                       case 8:


                                                            for (c1 = 0; c1 < 8; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }





                                                            break;

                                                       default:
                                                            c2 = 1;
                                                            break;


                                                  }//end  first switch



                                                  switch (f61)
                                                  {

                                                       case 0:
                                                            for (c1 = 1; c1 < 9; c1++)//check values>[f21] i.e if  f21=6   it checks the array positions 7,8,9,10,11,12,13,14  
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;



                                                       case 1:
                                                            for (c1 = 1; c1 < 8; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 1; c1++)//check values<[f21]  i.e if f21= 6   it checks the array positions   5,4,3,2,1,0
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;
                                                       case 2:
                                                            for (c1 = 1; c1 < 7; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;



                                                       case 3:
                                                            for (c1 = 1; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }
                                                            break;


                                                       case 4:
                                                            for (c1 = 1; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;

                                                       case 5:
                                                            for (c1 = 1; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }
                                                            break;

                                                       case 6:
                                                            for (c1 = 1; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;



                                                       case 7:
                                                            for (c1 = 1; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 7; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;







                                                       case 8:


                                                            for (c1 = 0; c1 < 8; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }





                                                            break;

                                                       default:
                                                            c3 = 1;
                                                            break;


                                                  }//end  second switch






                                             }//end here




                                             else
                                                             if (flag_num == 6)
                                             {

                                                  gm = 1;
                                                  switch (f21)
                                                  {

                                                       case 0:
                                                            for (c1 = 1; c1 < 6; c1++)//check values>[f21] i.e if  f21=6   it checks the array positions 7,8,9,10,11,12,13,14  
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;



                                                       case 1:
                                                            for (c1 = 1; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 1; c1++)//check values<[f21]  i.e if f21= 6   it checks the array positions   5,4,3,2,1,0
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;

                                                       case 2:
                                                            for (c1 = 1; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;


                                                       case 3:
                                                            for (c1 = 1; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }
                                                            break;

                                                       case 4:
                                                            for (c1 = 1; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;













                                                       case 5:


                                                            for (c1 = 0; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }





                                                            break;

                                                       default:
                                                            c2 = 1;
                                                            break;


                                                  }//end  first switch



                                                  switch (f61)
                                                  {

                                                       case 0:
                                                            for (c1 = 1; c1 < 6; c1++)//check values>[f21] i.e if  f21=6   it checks the array positions 7,8,9,10,11,12,13,14  
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;



                                                       case 1:
                                                            for (c1 = 1; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 1; c1++)//check values<[f21]  i.e if f21= 6   it checks the array positions   5,4,3,2,1,0
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;
                                                       case 2:
                                                            for (c1 = 1; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;



                                                       case 3:
                                                            for (c1 = 1; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }
                                                            break;


                                                       case 4:
                                                            for (c1 = 1; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;















                                                       case 5:


                                                            for (c1 = 0; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }





                                                            break;

                                                       default:
                                                            c3 = 1;
                                                            break;















                                                  }//end  second switch






                                             }//end here









                                             else
                                                             if (flag_num == 5)
                                             //ghost_mode:
                                             {
                                                  if (gm == 0)
                                                  {
                                                       MessageBox.Show("Inside main:Mode 6  must run first to enable ghost mode");
                                                       goto end;
                                                  }
                                                  MessageBox.Show("Ghost mode is initiated");
                                                  ghost_mode();
                                                  ghost_search = 0;
                                                  //gm = 0;
                                                  goto end;
                                                  switch (f21)
                                                  {

                                                       case 0:
                                                            for (c1 = 1; c1 < 5; c1++)//check values>[f21] i.e if  f21=6   it checks the array positions 7,8,9,10,11,12,13,14  
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;



                                                       case 1:
                                                            for (c1 = 1; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 1; c1++)//check values<[f21]  i.e if f21= 6   it checks the array positions   5,4,3,2,1,0
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;

                                                       case 2:
                                                            for (c1 = 1; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;


                                                       case 3:
                                                            for (c1 = 1; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }
                                                            break;
                                                       /*
                                                  case 4:
                                                       for (c1 = 1; c1 < 1; c1++)
                                                       {
                                                            if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                 c2 = 1;

                                                       }
                                                       for (c1 = 0; c1 < 4; c1++)
                                                       {
                                                            if (startAuto151[f21] == startAuto151[c1])
                                                                 c2 = 1;

                                                       }

                                                       break;

                                                  */











                                                       case 4:


                                                            for (c1 = 0; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }





                                                            break;

                                                       default:
                                                            c2 = 1;
                                                            break;


                                                  }//end  first switch



                                                  switch (f61)
                                                  {

                                                       case 0:
                                                            for (c1 = 1; c1 < 5; c1++)//check values>[f21] i.e if  f21=6   it checks the array positions 7,8,9,10,11,12,13,14  
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;



                                                       case 1:
                                                            for (c1 = 1; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 1; c1++)//check values<[f21]  i.e if f21= 6   it checks the array positions   5,4,3,2,1,0
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;
                                                       case 2:
                                                            for (c1 = 1; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;



                                                       case 3:
                                                            for (c1 = 1; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }
                                                            break;

                                                       /*
                                                  case 4:
                                                       for (c1 = 1; c1 < 1; c1++)
                                                       {
                                                            if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                 c3 = 1;

                                                       }
                                                       for (c1 = 0; c1 < 4; c1++)
                                                       {
                                                            if (startAuto151[f61] == startAuto151[c1])
                                                                 c3 = 1;

                                                       }

                                                       break;





                                                       */









                                                       case 4:


                                                            for (c1 = 0; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }





                                                            break;

                                                       default:
                                                            c3 = 1;
                                                            break;















                                                  }//end  second switch






                                             }//end here














                                             else
                                                                 if (flag_num == 10)
                                             {


                                                  switch (f21)
                                                  {

                                                       case 0:
                                                            for (c1 = 1; c1 < 10; c1++)//check values>[f21] i.e if  f21=6   it checks the array positions 7,8,9,10,11,12,13,14  
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;



                                                       case 1:
                                                            for (c1 = 1; c1 < 9; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 1; c1++)//check values<[f21]  i.e if f21= 6   it checks the array positions   5,4,3,2,1,0
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;

                                                       case 2:
                                                            for (c1 = 1; c1 < 8; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;


                                                       case 3:
                                                            for (c1 = 1; c1 < 7; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }
                                                            break;

                                                       case 4:
                                                            for (c1 = 1; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;

                                                       case 5:
                                                            for (c1 = 1; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }
                                                            break;

                                                       case 6:
                                                            for (c1 = 1; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;


                                                       case 7:
                                                            for (c1 = 1; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 7; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;

                                                       case 8:
                                                            for (c1 = 1; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[f21 + c1])
                                                                      c2 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 8; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }

                                                            break;






                                                       case 9:


                                                            for (c1 = 0; c1 < 9; c1++)
                                                            {
                                                                 if (startAuto151[f21] == startAuto151[c1])
                                                                      c2 = 1;

                                                            }





                                                            break;

                                                       default:
                                                            c2 = 1;
                                                            break;


                                                  }//end  first switch



                                                  switch (f61)
                                                  {

                                                       case 0:
                                                            for (c1 = 1; c1 < 10; c1++)//check values>[f21] i.e if  f21=6   it checks the array positions 7,8,9,10,11,12,13,14  
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;



                                                       case 1:
                                                            for (c1 = 1; c1 < 9; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 1; c1++)//check values<[f21]  i.e if f21= 6   it checks the array positions   5,4,3,2,1,0
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;//if there is any dublicate value in the array  increment  int  c2

                                                            }
                                                            break;
                                                       case 2:
                                                            for (c1 = 1; c1 < 8; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;



                                                       case 3:
                                                            for (c1 = 1; c1 < 7; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }
                                                            break;


                                                       case 4:
                                                            for (c1 = 1; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;

                                                       case 5:
                                                            for (c1 = 1; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 5; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }
                                                            break;

                                                       case 6:
                                                            for (c1 = 1; c1 < 4; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 6; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;


                                                       case 7:
                                                            for (c1 = 1; c1 < 3; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 7; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;

                                                       case 8:
                                                            for (c1 = 1; c1 < 2; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[f61 + c1])
                                                                      c3 = 1;

                                                            }
                                                            for (c1 = 0; c1 < 8; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }

                                                            break;






                                                       case 9:


                                                            for (c1 = 0; c1 < 9; c1++)
                                                            {
                                                                 if (startAuto151[f61] == startAuto151[c1])
                                                                      c3 = 1;

                                                            }





                                                            break;

                                                       default:
                                                            c3 = 1;
                                                            break;


                                                  }//end  second switch






                                             }//end here
















                                             startflag = 1;

                                        }      //end  while



                                        if (C22 > 1)
                                        {
                                             i22 = comp_history();


                                             if (i22 == 1)
                                                  goto start_again;

                                        }



                                        temp = startAuto151[f21];

                                        if (frep > 499 && winflag == 1)
                                        {

                                             winflag = 0;

                                             startAuto151[tempf21] = tempif21;

                                             startAuto151[tempf61] = tempif61;






                                        }


                                   } while (frep < 200);//end  do  while
                                   frep = 0;
                              }//end   for
                               //loopflag++;
                               // textBox18.Text = loopflag.ToString();
                         } while (repflag2 < 2);
                    } //while (endflag == 0 && f23 < Convert.ToInt32(textBox17.Text));//end   processing if mm  box  is reached  and endflag is 0
                    while (endflag == 0); //&& f23 < Convert.ToInt32(textBox17.Text)) ;//end   processing if mm  box  is reached  and endflag is 0

                    //end  future  loop

                    end:
                MessageBox.Show("END of  auto scan");

            }



        }

          public void ghost_mode()

          {
               int g4 = 0;
               string output4 = "";
               MessageBox.Show("Inside  ghost_mode");

               for (int g1 = 0; g1 < draws.Count; ++g1)

               {
                    g4 = 0;
                    // if (startAuto151[c3] == draws[f12].num1 || startAuto151[c3] == draws[f12].num2 || startAuto151[c3] == draws[f12].num3 || startAuto151[c3] == draws[f12].num4 || startAuto151[c3] == draws[f12].num5)
                    for (int g2 = g1 + 1; g2 < draws.Count; ++g2)
                    {
                         if ((draws[g1].num1 == draws[g2].num1)&& (draws[g1].num2 == draws[g2].num2)&& (draws[g1].num3 == draws[g2].num3)&& (draws[g1].num4 == draws[g2].num4)&& (draws[g1].num5 == draws[g2].num5))
                         { 
                              output4 += draws[g1].date2.ToString() + " " + draws[g1].num1.ToString() + " " + draws[g1].num2.ToString() + " " + draws[g1].num3.ToString() + " " + draws[g1].num4.ToString() + " " + draws[g1].num5.ToString() + "       " + draws[g1].joker.ToString() + "\n";
                         
                              output4 += Convert.ToString(f22) + "\n";
                              ++g4;
                         }
                    }
                    if (g4 > 0)
                    {
                         txtResults2.Text += output4;
                         MessageBox.Show("Match  was found");

                         output4 = "";
                    }

               }
               
          }

        public void nbm_mode_adjust()
        {
            if (nbm_flag_auto == 1)
            {
                switch (nbm_delta_total)
                {

                    case 1:
                        for (int a1 = 0; a1 < flag_num; a1++)
                        {
                            if (startAuto16[a1 + 1] - startAuto16[a1] > 1)

                                startAuto15[a1]++;
                            nbm_loop_count++;
                            for (int a2 = 0; a2 < flag_num; a2++)
                            {
                                tempStartAuto15[nbm_loop_count, a2] = startAuto15[a2];
                            }

                            if ((a1 == 0) && startAuto16[a1] == 1 && startAuto16[flag_num - 1] != 45)
                                startAuto15[a1] = 45;
                            else
                                if ((a1 == 0) && startAuto16[a1] != 1)
                                {
                                    startAuto15[a1]--;
                                    startAuto15[a1]--;
                                }



                                else
                                    if ((startAuto16[a1] - startAuto16[a1 - 1] > 1) && (a1 != 0))
                                    {
                                        startAuto15[a1]--;
                                        startAuto15[a1]--;
                                    }




                            nbm_loop_count++;

                            for (int a2 = 0; a2 < flag_num; a2++)
                            {
                                tempStartAuto15[nbm_loop_count, a2] = startAuto15[a2];
                            }

                            for (int a2 = 0; a2 < flag_num; a2++)
                            {
                                startAuto15[a2] = startAuto16[a2];
                            }







                            // nbm_loop_count = 14;

                        }


                        break;


                    case 2:

                        for (int a1 = 0; a1 < flag_num; a1++)
                        {
                            if (startAuto16[a1 + 1] - startAuto16[a1] > 1)

                                startAuto15[a1]++;
                            nbm_loop_count++;
                            for (int a2 = 0; a2 < flag_num; a2++)
                            {
                                tempStartAuto15[nbm_loop_count, a2] = startAuto15[a2];
                            }

                            if ((a1 == 0) && startAuto16[a1] == 1 && startAuto16[flag_num - 1] != 45)
                                startAuto15[a1] = 45;
                            else
                                if ((a1 == 0) && startAuto16[a1] != 1)
                                {
                                    startAuto15[a1]--;
                                    startAuto15[a1]--;
                                }



                                else
                                    if ((startAuto16[a1] - startAuto16[a1 - 1] > 1) && (a1 != 0))
                                    {
                                        startAuto15[a1]--;
                                        startAuto15[a1]--;
                                    }




                            nbm_loop_count++;

                            for (int a2 = 0; a2 < flag_num; a2++)
                            {
                                tempStartAuto15[nbm_loop_count, a2] = startAuto15[a2];
                            }

                            for (int a2 = 0; a2 < flag_num; a2++)
                            {
                                startAuto15[a2] = startAuto16[a2];
                            }







                            // nbm_loop_count = 14;

                        }



                        break;



                    //   case 3:
                    //   break;
                    //   case 4:
                    //   break;
                    // case 5:
                    //    break;
                    case 6:

                        for (int a1 = 0; a1 < flag_num; a1++)
                        {
                            if (startAuto16[a1 + 1] - startAuto16[a1] > 1)

                                startAuto15[a1]++;
                            nbm_loop_count++;
                            for (int a2 = 0; a2 < flag_num; a2++)
                            {
                                tempStartAuto15[nbm_loop_count, a2] = startAuto15[a2];
                            }

                            if ((a1 == 0) && startAuto16[a1] == 1 && startAuto16[flag_num - 1] != 45)
                                startAuto15[a1] = 45;
                            else
                                if ((a1 == 0) && startAuto16[a1] != 1)
                                {
                                    startAuto15[a1]--;
                                    startAuto15[a1]--;
                                }



                                else
                                    if ((startAuto16[a1] - startAuto16[a1 - 1] > 1) && (a1 != 0))
                                    {
                                        startAuto15[a1]--;
                                        startAuto15[a1]--;
                                    }




                            nbm_loop_count++;

                            for (int a2 = 0; a2 < flag_num; a2++)
                            {
                                tempStartAuto15[nbm_loop_count, a2] = startAuto15[a2];
                            }

                            for (int a2 = 0; a2 < flag_num; a2++)
                            {
                                startAuto15[a2] = startAuto16[a2];
                            }







                            // nbm_loop_count = 14;

                        }



                        break;













                    default:
                        MessageBox.Show("This  configuration  is not supported yet.No NBM mode is enabled");
                        nbm_flag_auto = 0;


                        break;



                }

            }
            else
                if (nbm_flag_man == 1)
                {


                }

        }



        public void add_history_7()
        {
            for (int out2 = 0; out2 < flag_num; out2++)
            {

                history_7[C22, out2] = startAuto151[out2];
            }

            using (System.IO.StreamWriter sr = new System.IO.StreamWriter("c:\\data\\file.txt"))
            {
                foreach (var item in history_7)
                {
                    sr.WriteLine(item);
                }
            }


        }
        int c24 = 0;
        int c29 = 0;

        public int comp_history()
        {

            i22 = 0;

            for (int c21 = 1; c21 <= C22; c21++)
            {
                for (int c29 = 0; c29 < flag_num; c29++)
                {

                    for (int out2 = 0; out2 < flag_num; out2++)
                    {

                        if (history_7[c21, c29] == startAuto151[out2])
                            c24++;
                    }
                }
                if (c24 == flag_num )
                    i22 = 1;
                c24 = 0;
            }



            return i22;

        }

        public void dm_auto_scan()
        {
            MessageBox.Show("hi   from  auto scan2....The  Data mining  Has been enabled");



            lock (this)
            {

                for (int f40 = 0; f40 < flag_num; f40++)
                {
                    startAuto151[f40] = maxAutotemp15[f40];

                }
                string output1 = " ";
                txtResults.Text = output1;
                if (f18 == 1)
                {
                    fill_list();
                    f18 = 0;
                }
                repflag = 1;
                f14 = 0;
                f12 = 0;
                loopflag = 0;
                //start  future  loop
                int f26 = 0, f28 = 0;
                f28 = draws.Count;

                do
                {

                    f42 = 0;
                    {
                        data_mine_temp[0, f42] = draws[f26].num1;

                        data_mine_temp[0, f42 + 1] = draws[f26].num2;

                        data_mine_temp[0, f42 + 2] = draws[f26].num3;
                        data_mine_temp[0, f42 + 3] = draws[f26].num4;

                        data_mine_temp[0, f42 + 4] = draws[f26].num5;

                    }
                    for (int dmm1 = 0; dmm1 < 31; dmm1++)
                    {

                        /*   if (dmm1 == 0)

                               fl2 = 5;
                           else if
                             ( dmm1 > 0 && dmm1 < 6)
                               fl2 = 4;
                           else if (dmm1 > 5 && dmm1 < 16)
                               fl2 = 3;
                           else if
                               (dmm1 > 15 && dmm1 < 26)
                               fl2 = 2;
                           else if
                              (dmm1 > 25 && dmm1 < 31)
                               fl2 = 1;
                            */

                        /*

                        for (int dmm2 = 0; dmm2 < 5; dmm2++)
                        {
                            data_mine11[dmm1, data_mine1[dmm1, dmm2]] = data_mine_temp[0, dmm2];

                           // data_mine1[dmm1, dmm2]


                        }
                         */



                        data_mine11[0, 0] = data_mine_temp[0, 0];
                        data_mine11[0, 1] = data_mine_temp[0, 1];
                        data_mine11[0, 2] = data_mine_temp[0, 2];
                        data_mine11[0, 3] = data_mine_temp[0, 3];
                        data_mine11[0, 4] = data_mine_temp[0, 4];


                        data_mine11[1, 0] = data_mine_temp[0, 0];
                        data_mine11[1, 1] = data_mine_temp[0, 1];
                        data_mine11[1, 2] = data_mine_temp[0, 2];
                        data_mine11[1, 3] = data_mine_temp[0, 3];
                        data_mine11[1, 4] = data_mine_temp[0, 0];

                        data_mine11[2, 0] = data_mine_temp[0, 0];
                        data_mine11[2, 1] = data_mine_temp[0, 2];
                        data_mine11[2, 2] = data_mine_temp[0, 3];
                        data_mine11[2, 3] = data_mine_temp[0, 4];
                        data_mine11[2, 4] = data_mine_temp[0, 0];

                        data_mine11[3, 0] = data_mine_temp[0, 1];
                        data_mine11[3, 1] = data_mine_temp[0, 2];
                        data_mine11[3, 2] = data_mine_temp[0, 3];
                        data_mine11[3, 3] = data_mine_temp[0, 4];
                        data_mine11[3, 4] = data_mine_temp[0, 0];

                        data_mine11[4, 0] = data_mine_temp[0, 0];
                        data_mine11[4, 1] = data_mine_temp[0, 1];
                        data_mine11[4, 2] = data_mine_temp[0, 2];
                        data_mine11[4, 3] = data_mine_temp[0, 4];
                        data_mine11[4, 4] = data_mine_temp[0, 0];

                        data_mine11[5, 0] = data_mine_temp[0, 0];
                        data_mine11[5, 1] = data_mine_temp[0, 1];
                        data_mine11[5, 2] = data_mine_temp[0, 3];
                        data_mine11[5, 3] = data_mine_temp[0, 4];
                        data_mine11[5, 4] = data_mine_temp[0, 0];



                        data_mine11[6, 0] = data_mine_temp[0, 1];
                        data_mine11[6, 1] = data_mine_temp[0, 2];
                        data_mine11[6, 2] = data_mine_temp[0, 3];
                        data_mine11[6, 3] = data_mine_temp[0, 0];
                        data_mine11[6, 4] = data_mine_temp[0, 0];

                        data_mine11[7, 0] = data_mine_temp[0, 2];
                        data_mine11[7, 1] = data_mine_temp[0, 3];
                        data_mine11[7, 2] = data_mine_temp[0, 4];
                        data_mine11[7, 3] = data_mine_temp[0, 0];
                        data_mine11[7, 4] = data_mine_temp[0, 0];

                        data_mine11[8, 0] = data_mine_temp[0, 0];
                        data_mine11[8, 1] = data_mine_temp[0, 2];
                        data_mine11[8, 2] = data_mine_temp[0, 3];
                        data_mine11[8, 3] = data_mine_temp[0, 0];
                        data_mine11[8, 4] = data_mine_temp[0, 0];


                        data_mine11[9, 0] = data_mine_temp[0, 0];
                        data_mine11[9, 1] = data_mine_temp[0, 3];
                        data_mine11[9, 2] = data_mine_temp[0, 4];
                        data_mine11[9, 3] = data_mine_temp[0, 0];
                        data_mine11[9, 4] = data_mine_temp[0, 0];

                        data_mine11[10, 0] = data_mine_temp[0, 0];
                        data_mine11[10, 1] = data_mine_temp[0, 2];
                        data_mine11[10, 2] = data_mine_temp[0, 3];
                        data_mine11[10, 3] = data_mine_temp[0, 0];
                        data_mine11[10, 4] = data_mine_temp[0, 0];
                        /*
                                               data_mine11[0, 0] = data_mine_temp[0, 1];
                                               data_mine11[0, 1] = data_mine_temp[0, 2];
                                               data_mine11[0, 2] = data_mine_temp[0, 4];
                                               data_mine11[0, 3] = data_mine_temp[0, 0];
                                               data_mine11[0, 4] = data_mine_temp[0, 0];
                                        */

                        data_mine11[11, 0] = data_mine_temp[0, 0];
                        data_mine11[11, 1] = data_mine_temp[0, 2];
                        data_mine11[11, 2] = data_mine_temp[0, 4];
                        data_mine11[11, 3] = data_mine_temp[0, 0];
                        data_mine11[11, 4] = data_mine_temp[0, 0];

                        data_mine11[12, 0] = data_mine_temp[0, 0];
                        data_mine11[12, 1] = data_mine_temp[0, 1];
                        data_mine11[12, 2] = data_mine_temp[0, 4];
                        data_mine11[12, 3] = data_mine_temp[0, 0];
                        data_mine11[12, 4] = data_mine_temp[0, 0];

                        data_mine11[13, 0] = data_mine_temp[0, 0];
                        data_mine11[13, 1] = data_mine_temp[0, 1];
                        data_mine11[13, 2] = data_mine_temp[0, 3];
                        data_mine11[13, 3] = data_mine_temp[0, 0];
                        data_mine11[13, 4] = data_mine_temp[0, 0];


                        data_mine11[14, 0] = data_mine_temp[0, 0];
                        data_mine11[14, 1] = data_mine_temp[0, 1];
                        data_mine11[14, 2] = data_mine_temp[0, 2];
                        data_mine11[14, 3] = data_mine_temp[0, 0];
                        data_mine11[14, 4] = data_mine_temp[0, 0];

                        data_mine11[15, 0] = data_mine_temp[0, 1];
                        data_mine11[15, 1] = data_mine_temp[0, 3];
                        data_mine11[15, 2] = data_mine_temp[0, 4];
                        data_mine11[15, 3] = data_mine_temp[0, 0];
                        data_mine11[15, 4] = data_mine_temp[0, 0];

                        data_mine11[16, 0] = data_mine_temp[0, 0];
                        data_mine11[16, 1] = data_mine_temp[0, 4];
                        data_mine11[16, 2] = data_mine_temp[0, 0];
                        data_mine11[16, 3] = data_mine_temp[0, 0];
                        data_mine11[16, 4] = data_mine_temp[0, 0];


                        data_mine11[17, 0] = data_mine_temp[0, 0];
                        data_mine11[17, 1] = data_mine_temp[0, 3];
                        data_mine11[17, 2] = data_mine_temp[0, 0];
                        data_mine11[17, 3] = data_mine_temp[0, 0];
                        data_mine11[17, 4] = data_mine_temp[0, 0];

                        data_mine11[18, 0] = data_mine_temp[0, 0];
                        data_mine11[18, 1] = data_mine_temp[0, 2];
                        data_mine11[18, 2] = data_mine_temp[0, 0];
                        data_mine11[18, 3] = data_mine_temp[0, 0];
                        data_mine11[18, 4] = data_mine_temp[0, 0];

                        data_mine11[19, 0] = data_mine_temp[0, 0];
                        data_mine11[19, 1] = data_mine_temp[0, 1];
                        data_mine11[19, 2] = data_mine_temp[0, 0];
                        data_mine11[19, 3] = data_mine_temp[0, 0];
                        data_mine11[19, 4] = data_mine_temp[0, 0];


                        data_mine11[20, 0] = data_mine_temp[0, 1];
                        data_mine11[20, 1] = data_mine_temp[0, 4];
                        data_mine11[20, 2] = data_mine_temp[0, 0];
                        data_mine11[20, 3] = data_mine_temp[0, 0];
                        data_mine11[20, 4] = data_mine_temp[0, 0];

                        data_mine11[21, 0] = data_mine_temp[0, 1];
                        data_mine11[21, 1] = data_mine_temp[0, 3];
                        data_mine11[21, 2] = data_mine_temp[0, 0];
                        data_mine11[21, 3] = data_mine_temp[0, 0];
                        data_mine11[21, 4] = data_mine_temp[0, 0];

                        data_mine11[22, 0] = data_mine_temp[0, 1];
                        data_mine11[22, 1] = data_mine_temp[0, 2];
                        data_mine11[22, 2] = data_mine_temp[0, 0];
                        data_mine11[22, 3] = data_mine_temp[0, 0];
                        data_mine11[22, 4] = data_mine_temp[0, 0];


                        data_mine11[23, 0] = data_mine_temp[0, 2];
                        data_mine11[23, 1] = data_mine_temp[0, 3];
                        data_mine11[23, 2] = data_mine_temp[0, 0];
                        data_mine11[23, 3] = data_mine_temp[0, 0];
                        data_mine11[23, 4] = data_mine_temp[0, 0];

                        data_mine11[24, 0] = data_mine_temp[0, 2];
                        data_mine11[24, 1] = data_mine_temp[0, 4];
                        data_mine11[24, 2] = data_mine_temp[0, 0];
                        data_mine11[24, 3] = data_mine_temp[0, 0];
                        data_mine11[24, 4] = data_mine_temp[0, 0];

                        data_mine11[25, 0] = data_mine_temp[0, 3];
                        data_mine11[25, 1] = data_mine_temp[0, 4];
                        data_mine11[25, 2] = data_mine_temp[0, 0];
                        data_mine11[25, 3] = data_mine_temp[0, 0];
                        data_mine11[25, 4] = data_mine_temp[0, 0];


                        data_mine11[26, 0] = data_mine_temp[0, 0];
                        data_mine11[26, 1] = data_mine_temp[0, 0];
                        data_mine11[26, 2] = data_mine_temp[0, 0];
                        data_mine11[26, 3] = data_mine_temp[0, 0];
                        data_mine11[26, 4] = data_mine_temp[0, 0];

                        data_mine11[27, 0] = data_mine_temp[0, 1];
                        data_mine11[27, 1] = data_mine_temp[0, 0];
                        data_mine11[27, 2] = data_mine_temp[0, 0];
                        data_mine11[27, 3] = data_mine_temp[0, 0];
                        data_mine11[27, 4] = data_mine_temp[0, 0];

                        data_mine11[28, 0] = data_mine_temp[0, 2];
                        data_mine11[28, 1] = data_mine_temp1[0, 0];
                        data_mine11[28, 2] = data_mine_temp[0, 0];
                        data_mine11[28, 3] = data_mine_temp[0, 0];
                        data_mine11[28, 4] = data_mine_temp[0, 0];


                        data_mine11[29, 0] = data_mine_temp[0, 3];
                        data_mine11[29, 1] = data_mine_temp[0, 0];
                        data_mine11[29, 2] = data_mine_temp[0, 0];
                        data_mine11[29, 3] = data_mine_temp[0, 0];
                        data_mine11[29, 4] = data_mine_temp[0, 0];

                        data_mine11[30, 0] = data_mine_temp[0, 4];
                        data_mine11[30, 1] = data_mine_temp[0, 0];
                        data_mine11[30, 2] = data_mine_temp[0, 0];
                        data_mine11[30, 3] = data_mine_temp[0, 0];
                        data_mine11[30, 4] = data_mine_temp[0, 0];


















                    }

                    for (f12 = f26 + 1; f12 < draws.Count; f12++)
                    {

                        int fl1 = 0;
                        int fl2 = 0;
                        int c2 = 0;
                        for (c3 = 0; c3 < 31; c3++)
                        {
                            if (c3 == 0)

                                fl1 = 5;
                            else if
                               (c3 > 0 && c3 < 6)
                                fl1 = 4;
                            else if (c3 > 5 && c3 < 16)
                                fl1 = 3;
                            else if
                                (c3 > 15 && c3 < 26)
                                fl1 = 2;
                            else if
                               (c3 > 25 && c3 < 31)
                                fl1 = 1;


                            for (c2 = 0; c2 < fl1; c2++)//fl1  define the numbers to be checked
                            {
                                if ((data_mine11[c3, c2] == draws[f12].num1) || (data_mine11[c3, c2] == draws[f12].num2) || (data_mine11[c3, c2] == draws[f12].num3) || (data_mine11[c3, c2] == draws[f12].num4) || (data_mine11[c3, c2] == draws[f12].num5))
                                    dm_flag++;

                            }
                            if (dm_flag == fl1)
                            {
                                tot_dm_flag[c3]++;//data_mine  support  factor   ,necessary  also for the creation   of data_mine confidence factor
                                //dm_flag = 0;

                            }

                            // if((dm_flag==2)&&(c3>15 && c3<26))
                            //MessageBox.Show("Hi   from  data_mining auto scan.The value of  f26= " + f26, "END OF MINING PROCESS ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dm_flag = 0;
                        }



                        for (int c31 = 0; c31 < 31; c31++)
                        {
                            if (tot_dm_flag[c31] == 1)

                                tot_dm_flag2[c31] += 1;
                        }

                        // tot_dm_flag2[c31] = tot_dm_flag[c31];

                        for (c3 = 0; c3 < 31; c3++)
                            tot_dm_flag[c3] = 0;


                    }

                    for (int c32 = 0; c32 < 31; c32++)
                    {

                        // if (c32==20)
                        // MessageBox.Show("Hi   from  data_mining auto scan.The value of  f26= " + f26, "END OF MINING PROCESS ", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        data_mine2[f26, c32] = tot_dm_flag2[c32];//combination of draw   numbers  occurances
                    }
                    data_mine2[f26, 31] = f26;//draw index
                    for (int c34 = 32; c34 < 63; c34++)
                        data_mine2[f26, c34] = data_mine_count[c34];//combination draw number count(1-31)


                    for (int c31 = 0; c31 < 31; c31++)
                        tot_dm_flag2[c31] = 0;

                    // if (f26 == 500)

                    //  MessageBox.Show("Hi   from  data_mining auto scan.The value of  f26= " + f26, "END OF MINING PROCESS ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (f26 == (draws.Count - 100))
                        MessageBox.Show("Hi   from  data_mining auto scan.The value of  f26= " + f26, "END OF MINING PROCESS.THE SUPPORT BUTTON IS ENABLED ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    f26++;
                } while (endflag == 0 && f26 < (draws.Count - 100));
                Data_mine_support_btn.Enabled = true;


                MessageBox.Show("END OF SUPPORT FACTOR CALCULATION ,WE CONTINUE WITH CONFIDENCE FACTOR  CALCULATION  OF MINING PROCESS  FOR DRAWS UNTIL  f26= " + f26, " SUPPORT/CONFIDENCE FACTOR    OF MINING PROCESS ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                do
                {





                    endflag1 = 1;

                } while (endflag1 == 0 && f226 < (draws.Count - 100));
                MessageBox.Show("END OF CONFIDENCE  FACTOR CALCULATION    FOR DRAWS UNTIL  f26= " + f26, " SUPPORT/CONFIDENCE FACTOR    OF MINING PROCESS ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Data_mine_confidence_btn.Enabled = true;

            }
        }





        private void button4_Click(object sender, EventArgs e)
        {
            C22 = 0;
            endflag = 1;
            checkBox2.Enabled = true;
            btnProcess.Enabled = true;
            btnSubmit.Enabled = true;
            groupBox10.Enabled = true;

            groupBox1.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox5.Enabled = true;
            groupBox7.Enabled = true;
            groupBox6.Enabled = true;
            groupBox9.Enabled = true;
            groupBox8.Enabled = true;
            button13.Enabled = true;
            button1.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button4.Enabled = false;

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        public int predict(int f51)
        {
            frep++;
            int f52 = winrandom.Next(1, 39);
            startAuto151[f51] = f52;

            return f51;
        }


        public int num8smaller()
        {

            for (sm1 = 0; sm1 < 7; sm1++)
            {

                if (numpar15[sm1] < numpar15[sm1 + 1])
                {
                    sm2 = sm1;

                    sm8 = numpar15[sm2] < numpar15[sm8] ? sm2 : sm8;
                }

            }

            return sm8;
        }



        public int num7smaller()
        {

            for (sm1 = 0; sm1 < 6; sm1++)
            {

                if (numpar15[sm1] < numpar15[sm1 + 1])
                {
                    sm2 = sm1;

                    sm8 = numpar15[sm2] < numpar15[sm8] ? sm2 : sm8;
                }

            }

            return sm8;
        }



        public int num9smaller()
        {

            for (sm1 = 0; sm1 < 8; sm1++)
            {

                if (numpar15[sm1] < numpar15[sm1 + 1])
                {
                    sm2 = sm1;

                    sm8 = numpar15[sm2] < numpar15[sm8] ? sm2 : sm8;
                }

            }

            return sm8;
        }


        public int num10smaller()
        {

            for (sm1 = 0; sm1 < 9; sm1++)
            {

                if (numpar15[sm1] < numpar15[sm1 + 1])
                {
                    sm2 = sm1;

                    sm8 = numpar15[sm2] < numpar15[sm8] ? sm2 : sm8;
                }

            }

            return sm8;
        }

        public int num6smaller()
        {

            for (sm1 = 0; sm1 < 5; sm1++)
            {

                if (numpar15[sm1] < numpar15[sm1 + 1])
                {
                    sm2 = sm1;

                    sm8 = numpar15[sm2] < numpar15[sm8] ? sm2 : sm8;
                }

            }

            return sm8;
        }

          public int num5smaller()
          {

               for (sm1 = 0; sm1 < 4; sm1++)
               {

                    if (numpar15[sm1] < numpar15[sm1 + 1])
                    {
                         sm2 = sm1;

                         sm8 = numpar15[sm2] < numpar15[sm8] ? sm2 : sm8;
                    }

               }

               return sm8;
          }













          public int num15smaller()
        {

            for (sm1 = 0; sm1 < 14; sm1++)
            {
                if (numpar15[sm1] < numpar15[sm1 + 1])
                {
                    sm2 = sm1;

                    sm3 = numpar15[sm2] < numpar15[sm3] ? sm2 : sm3;
                }

            }

            return sm3;
        }

        private void txtResults_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                //this.groupBox1.Enabled = false;
                this.groupBox4.Enabled = true;
 
            }
            flag_num = 8;
            f15 = 1;
            f5 = 0;
            if (radioButton7.Checked == true)
            {
                MessageBox.Show(" NUMBER_8 MODE WAS SELECTED....AI SOFTWARE  WILL BE SELECTED TO REFLECT THIS CHOISE");
                ai = 8;
            }

            //flug_num = 8;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


            if (radioButton5.Checked == true)
            {
                //  this.groupBox1.Enabled = false;
                this.groupBox4.Enabled = true;

            }
            flag_num = 10;
            f15 = 1;
            f5 = 0;












        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton5.Checked == true)
            {
                //   this.groupBox1.Enabled = false;
                this.groupBox4.Enabled = true;

            }
            flag_num = 9;
            f15 = 1;
            f5 = 0;











        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)

                dm1 = 1;
            else if (checkBox2.Checked == false)


                dm1 = 0;




        }

        private void Data_mine_support_btn_Click(object sender, EventArgs e)
        {


            DataTable dataTable = dataSet1.Tables[0];
            //int ri12=0;
            //ri12=Convert.ToInt32(txtUserSelect.Text);
            //i3=Convert.ToInt32(txtUserSelect.Text);
            DialogBox2 myDialogBox2 = new DialogBox2(draw11, data_mine2);

            //myDialogBox1.MdiParent = this;

            //myDialogBox1.Show();
            if (myDialogBox2.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("LEARNING STARTED  IN THE DATABASE");

            }





        }

        private void Data_mine_confidence_btn_Click(object sender, EventArgs e)
        {

            DataTable dataTable = dataSet1.Tables[0];
            //int ri12=0;
            //ri12=Convert.ToInt32(txtUserSelect.Text);
            //i3=Convert.ToInt32(txtUserSelect.Text);
            DialogBox4 myDialogBox4 = new DialogBox4(draw11, data_mine6);

            //myDialogBox1.MdiParent = this;

            //myDialogBox1.Show();
            if (myDialogBox4.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("LEARNING STARTED  IN THE DATABASE");

            }




        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                // this.groupBox1.Enabled = false;
                // this.groupBox4.Enabled = true;

            }
            win_cnt = 3;
            f15 = 1;
            f5 = 0;




        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                // this.groupBox1.Enabled = false;
                //this.groupBox4.Enabled = true;

            }
            win_cnt = 4;
            f15 = 1;
            f5 = 0;




        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                // this.groupBox1.Enabled = false;
                //this.groupBox4.Enabled = true;

            }
            win_cnt = 2;
            f15 = 1;
            f5 = 0;




        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton9.Checked == true)
            {
                //  this.groupBox1.Enabled = false;
                //this.groupBox4.Enabled = true;

            }
            win_cnt = 5;
            f15 = 1;
            f5 = 0;


        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                this.groupBox7.Enabled = true;
                nbm_flag = 1;
                nbm_flag_man = 1;

            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton14.Checked == true)
            {
                nbm_flag = 0;
                nbm_flag_man = 0;
                nbm_flag_auto = 0;


                this.groupBox7.Enabled = false;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                nbm_num1_flag = 1;
                this.numericUpDown1.Enabled = true;
                this.numericUpDown2.Enabled = true;
            }
            else
                if (checkBox1.Checked == false)
                {
                    nbm_num1_flag = 0;
                    this.numericUpDown1.Enabled = false;
                    this.numericUpDown2.Enabled = false;

                }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked == true)
            {
                nbm_num2_flag = 1;
                this.numericUpDown3.Enabled = true;
                this.numericUpDown4.Enabled = true;


            }
            else
                if (checkBox3.Checked == false)
                {
                    nbm_num2_flag = 0;
                    this.numericUpDown3.Enabled = false;
                    this.numericUpDown4.Enabled = false;

                }



        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox5.Checked == true)
            {
                nbm_num3_flag = 1;

                this.numericUpDown6.Enabled = true;
                this.numericUpDown5.Enabled = true;

            }
            else
                if (checkBox5.Checked == false)
                {
                    nbm_num3_flag = 0;

                    this.numericUpDown5.Enabled = false;
                    this.numericUpDown6.Enabled = false;


                }



        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                nbm_num4_flag = 1;
                this.numericUpDown7.Enabled = true;
                this.numericUpDown8.Enabled = true;



            }
            else
                if (checkBox4.Checked == false)
                {
                    nbm_num4_flag = 0;
                    this.numericUpDown7.Enabled = false;
                    this.numericUpDown8.Enabled = false;

                }


        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                nbm_num5_flag = 1;

                this.numericUpDown9.Enabled = true;
                this.numericUpDown10.Enabled = true;

            }
            else
                if (checkBox6.Checked == false)
                {
                    nbm_num5_flag = 0;
                    this.numericUpDown9.Enabled = false;
                    this.numericUpDown10.Enabled = false;

                }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
            {

                this.groupBox8.Enabled = true;
                this.groupBox7.Enabled = false;
                nbm_flag = 1;
                nbm_flag_auto = 1;

            }
            else
            {
                this.groupBox8.Enabled = false;
                // this.groupBox7.Enabled = false;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            toolStripMenuItem1.Enabled = txtResults2.SelectionLength > 0;
            toolStripMenuItem2.Enabled = txtResults2.SelectionLength > 0;
            toolStripMenuItem3.Enabled = txtResults2.SelectionLength > 0;

        }


        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

            toolStripMenuItem4.Enabled = txtResults.SelectionLength > 0;
            toolStripMenuItem5.Enabled = txtResults.SelectionLength > 0;
            toolStripMenuItem6.Enabled = txtResults.SelectionLength > 0;

        }





        private void toolStripMenuItem3_Click(object sender, CancelEventArgs e)
        {



            txtResults2.Copy();

        }

        private void toolStripMenuItem2_Click(object sender, CancelEventArgs e)
        {



            txtResults2.Cut();

        }

        private void toolStripMenuItem1_Click(object sender, CancelEventArgs e)
        {



            txtResults2.Paste();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtResults2.Paste();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            txtResults2.Cut();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            txtResults2.Copy();


        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            txtResults.Copy();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            txtResults.Cut();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            txtResults.Paste();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox7.Checked == true)
            {
                nbm_num6_flag = 1;

                this.numericUpDown13.Enabled = true;
                this.numericUpDown14.Enabled = true;

            }
            else
                if (checkBox6.Checked == false)
                {
                    nbm_num7_flag = 0;
                    this.numericUpDown13.Enabled = false;
                    this.numericUpDown14.Enabled = false;

                }









        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (checkBox8.Checked == true)
                {
                    nbm_num7_flag = 1;

                    this.numericUpDown15.Enabled = true;
                    this.numericUpDown16.Enabled = true;

                }
                else
                    if (checkBox8.Checked == false)
                    {
                        nbm_num7_flag = 0;
                        this.numericUpDown15.Enabled = false;
                        this.numericUpDown16.Enabled = false;

                    }

            }








        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((conflag10 == 0) & (conflag2 == 1))
            {
                try
                {

                    //oleDbConnection2.Open();
                    OleDbCommandBuilder c1 = new OleDbCommandBuilder(oleDbDataAdapter1);
                    oleDbDataAdapter1.UpdateCommand = c1.GetUpdateCommand();
                   // MessageBox.Show("1");
                    //  OleDbCommandBuilder b2 = new OleDbCommandBuilder(oleDbDataAdapter2);
                    // b2.GetUpdateCommand();
                   // MessageBox.Show("2");
                    // adapter.InsertCommand= command;
                   // MessageBox.Show("3");
                    //MessageBox.Show(oleDbDataAdapter2.UpdateCommand.CommandText);
                    MessageBox.Show("Update command  :"+oleDbDataAdapter1.UpdateCommand.CommandText);
                   // MessageBox.Show("4");
                    //MessageBox.Show(adapter.TableMappings.ToString);
                    // oleDbDataAdapter2.InsertCommand.ExecuteNonQuery(oleDbDataAdapter2);
                    //OleDbCommandBuilder b1 = new OleDbCommandBuilder(oleDbDataAdapter2);
                    //adapter.Update(dt1);
                    //MessageBox.Show("41");
                    MessageBox.Show("Number of Tables active :  "+ Convert.ToString(dataSet1.Tables.Count));
                    oleDbDataAdapter1.Update(dataSet1, "joker1");
                   // MessageBox.Show("5");
                    MessageBox.Show("update was  ok to database ");


                    //MessageBox.Show(Convert.ToString(DataTable.));

                    oleDbDataAdapter1.Update(dataSet1, "joker1");

                    MessageBox.Show("update was  ok to database  ");
                }
                catch
                {

                    MessageBox.Show("Not possible to update Database    ");
                    MessageBox.Show("Trying to correct problem  and   updating Database   ");
                    //update2();
                }

                finally
                {

                    MessageBox.Show("Now you can try again to  update Database     ");

                }
            }

            else
            {
                update2();
            }

            button6.Enabled = false;
        }

        private void update2()
        {
            MessageBox.Show("Connection string  :  "+oleDbConnection4.ConnectionString);
            try
            {

                /*
        
                command = new OleDbCommand(
       "INSERT INTO JOKER1 (DATE1, ID,JOKERNUMBER,NUMBER1,NUMBER2,NUMBER3,NUMBER4,NUMBER5) " +
       "VALUES (?, ?, ?, ?, ? , ?, ?, ?)", oleDbConnection4);

                command.Parameters.Add(
                    "@DATE1", OleDbType.Date, 10, "DATE1");
                command.Parameters.Add(
                    "@ID", OleDbType.Numeric, 5, "ID");

                command.Parameters.Add(
                    "@JOKERNUMBER", OleDbType.Numeric, 10, "JOKERNUMBER");
                command.Parameters.Add(
                    "@NUMBER1", OleDbType.Numeric, 10, "NUMBER1");

                command.Parameters.Add(
                    "@NUMBER2", OleDbType.Numeric, 10, "NUMBER2");
                command.Parameters.Add(
                    "@NUMBER3", OleDbType.Numeric, 10, "NUMBER3");

                command.Parameters.Add(
                    "@NUMBER4", OleDbType.Numeric, 10, "NUMBER4");

                command.Parameters.Add(
                    "@NUMBER5", OleDbType.Numeric, 10, "NUMBER5");
                */
               // oleDbConnection4.Open();
                OleDbCommandBuilder b1 = new OleDbCommandBuilder(adapter);
             adapter.UpdateCommand=b1.GetUpdateCommand();
              //  MessageBox.Show("1");
              //  OleDbCommandBuilder b2 = new OleDbCommandBuilder(oleDbDataAdapter2);
               // b2.GetUpdateCommand();
              //  MessageBox.Show("2");
              // adapter.InsertCommand= command;
               // MessageBox.Show("3");
                //MessageBox.Show(oleDbDataAdapter2.UpdateCommand.CommandText);
                MessageBox.Show("Update command : "+adapter.UpdateCommand.CommandText);
               // MessageBox.Show("4");
                //MessageBox.Show(adapter.TableMappings.ToString);
                // oleDbDataAdapter2.InsertCommand.ExecuteNonQuery(oleDbDataAdapter2);
                //OleDbCommandBuilder b1 = new OleDbCommandBuilder(oleDbDataAdapter2);
                //adapter.Update(dt1);
               // MessageBox.Show("41");
                MessageBox.Show("Number of active tables :  "+Convert.ToString(dataSet1.Tables.Count));
                adapter.Update(dataSet4,"joker1");
              //  MessageBox.Show("5");
                MessageBox.Show("update was  ok for database ");
                
            }
            catch
            {

                MessageBox.Show("Not possible to update Database    ");
                MessageBox.Show("Trying to correct problem  and   updating Database   ");

            }
            button6.Enabled = false;
        }





        private void button5_Click(object sender, EventArgs e)
        {
            /*

            DataRow dRow = dataSet1.Tables["joker1"].NewRow();
            dataSet1.Tables["joker1"].Rows.Add(dRow);
            MaxRows = MaxRows + 1;
            inc = MaxRows - 1;


            */
            if ((conflag10 == 0) & (conflag2 == 1))
            {
                try
                {

                    //oleDbConnection2.Open();
                    OleDbCommandBuilder c1 = new OleDbCommandBuilder(oleDbDataAdapter1);
                    oleDbDataAdapter1.InsertCommand = c1.GetInsertCommand();
                  //  MessageBox.Show("1");
                    //  OleDbCommandBuilder b2 = new OleDbCommandBuilder(oleDbDataAdapter2);
                    // b2.GetUpdateCommand();
                   // MessageBox.Show("2");
                    // adapter.InsertCommand= command;
                   // MessageBox.Show("3");
                    //MessageBox.Show(oleDbDataAdapte r2.UpdateCommand.CommandText);
                    MessageBox.Show("Insert command : "+oleDbDataAdapter1.InsertCommand.CommandText);
                   // MessageBox.Show("4");
                    //MessageBox.Show(adapter.TableMappings.ToString);
                    // oleDbDataAdapter2.InsertCommand.ExecuteNonQuery(oleDbDataAdapter2);
                    //OleDbCommandBuilder b1 = new OleDbCommandBuilder(oleDbDataAdapter2);
                    //adapter.Update(dt1);
                   // MessageBox.Show("41");
                    MessageBox.Show("Number of active tables :  "+Convert.ToString(dataSet1.Tables.Count));
                    oleDbDataAdapter1.Update(dataSet1, "joker1");
                   // MessageBox.Show("5");
                    MessageBox.Show("update was  ok for database ");


                    //MessageBox.Show(Convert.ToString(DataTable.));

                    oleDbDataAdapter1.Update(dataSet1, "joker1");

                    MessageBox.Show("update was  ok for database  ");
                }
                catch
                {

                    MessageBox.Show("Not possible to update Database    ");
                    MessageBox.Show("Trying to correct problem  and   updating Database   ");
                    //update2();
                }
            }

            else
            {
                //update2();






                MessageBox.Show("Connection string  :  " + oleDbConnection4.ConnectionString);
                try
            {


/*
                command = new OleDbCommand(
       "INSERT INTO JOKER1 (DATE1, ID,JOKERNUMBER,NUMBER1,NUMBER2,NUMBER3,NUMBER4,NUMBER5) " +
       "VALUES (?, ?, ?, ?, ? , ?, ?, ?)", oleDbConnection4);

                command.Parameters.Add(
                    "@DATE1", OleDbType.Date, 10, "DATE1");
                command.Parameters.Add(
                    "@ID", OleDbType.Numeric, 5, "ID");

                command.Parameters.Add(
                    "@JOKERNUMBER", OleDbType.Numeric, 10, "JOKERNUMBER");
                command.Parameters.Add(
                    "@NUMBER1", OleDbType.Numeric, 10, "NUMBER1");

                command.Parameters.Add(
                    "@NUMBER2", OleDbType.Numeric, 10, "NUMBER2");
                command.Parameters.Add(
                    "@NUMBER3", OleDbType.Numeric, 10, "NUMBER3");

                command.Parameters.Add(
                    "@NUMBER4", OleDbType.Numeric, 10, "NUMBER4");

                command.Parameters.Add(
                    "@NUMBER5", OleDbType.Numeric, 10, "NUMBER5");
                    */
                //oleDbConnection4.Open();
                // OleDbCommandBuilder b1 = new OleDbCommandBuilder(oleDbDataAdapter2);
                // b1.GetInsertCommand();
               // MessageBox.Show("1");
                //  OleDbCommandBuilder b2 = new OleDbCommandBuilder(oleDbDataAdapter2);
                // b2.GetUpdateCommand();
               // MessageBox.Show("2");
                adapter.InsertCommand = command;
                    //  MessageBox.Show("3");
                    //MessageBox.Show(oleDbDataAdapter2.UpdateCommand.CommandText);
                    MessageBox.Show("Insert command : " + adapter.InsertCommand.CommandText);
                    // MessageBox.Show("4");
                    //MessageBox.Show(adapter.TableMappings.ToString);
                    // oleDbDataAdapter2.InsertCommand.ExecuteNonQuery(oleDbDataAdapter2);
                    //OleDbCommandBuilder b1 = new OleDbCommandBuilder(oleDbDataAdapter2);
                    //adapter.Update(dt1);
                    // MessageBox.Show("41");
                    // MessageBox.Show(Convert.ToString(dataSet1.Tables.Count));
                    adapter.Update(dataSet4, "joker1");
               // MessageBox.Show("5");
                MessageBox.Show("update was  ok for Database ");

            }
            catch
            {

                MessageBox.Show("Not possible to update Database     ");
                MessageBox.Show("Trying to correct problem  and   updating Database   ");

            }




        }


            button5.Enabled = false;



        }
        int lock_count_flag = 0;
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

            
            if (checkBox9.Checked == true)
            {
                lock_count_flag = 1;
                this.numericUpDown17.Enabled = true;

            }


            else
                if (checkBox9.Checked == false)
                {
                    lock_count_flag = 0;
                    this.numericUpDown17.Enabled = false;
                }

            
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox10.Checked == true)
            {
                scan_mode_flag = 1;
                this.button7.Enabled = true;

                groupBox1.Enabled = false;
                groupBox2.Enabled = false;

                groupBox7.Enabled = false;
                // groupBox10.Enabled = false;
                groupBox8.Enabled = false;
                groupBox6.Enabled = false;
                checkBox2.Enabled = false;
                button1.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                groupBox9.Enabled = false;
                btnProcess.Enabled = false;
                btnSubmit.Enabled = false;
                button13.Enabled = false;
                button4.Enabled = false;
                //checkBox10.Enabled = false;
                radioButton3.Enabled = false;

                Data_mine_support_btn.Enabled = false;

                Data_mine_confidence_btn.Enabled = false;


            }


            else
                if (checkBox10.Checked == false)
                {
                    scan_mode_flag = 0;
                    this.button7.Enabled = false;

                    checkBox2.Enabled = true;
                    btnProcess.Enabled = true;
                    btnSubmit.Enabled = true;
                    //groupBox10.Enabled = true;
                    //checkBox10.Enabled = true;
                    groupBox1.Enabled = true;
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;

                    groupBox7.Enabled = true;
                    groupBox6.Enabled = true;
                    groupBox9.Enabled = true;
                    groupBox8.Enabled = true;
                    button13.Enabled = true;
                    button1.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button4.Enabled = true;

                    radioButton3.Enabled = true;
                    Data_mine_support_btn.Enabled = true;

                    Data_mine_confidence_btn.Enabled = true;

                }







        }

        private void button7_Click(object sender, EventArgs e)
        {
            f14 = 1;
            checkBox10.Enabled = false;
            button8.Enabled = true;
            button7.Enabled = false;
            groupBox3.Enabled = false;
            groupBox5.Enabled = false;


            if (man1 == 0 && f15 == 1)
            {
                CheckForIllegalCrossThreadCalls = false;

                textBox16.Text = Convert.ToString(0);
                endflag = 0;
                new Thread(new ThreadStart(sm_auto_scan)).Start();
                //auto_scan2();
            }



        }

        private void button8_Click(object sender, EventArgs e)
        {

            checkBox10.Enabled = true;
            groupBox3.Enabled = true;
            groupBox5.Enabled = true;

            button7.Enabled = true;
            button8.Enabled = false;

            endflag = 1;
            rflag2 = 1;
            MessageBox.Show("END   of auto scan  mode");
        }





        public void sm_auto_scan()
        {
            lock (this)
            {



                for (int f40 = 0; f40 < flag_num; f40++)
                {
                    startAuto151[f40] = maxAutotemp15[f40];
                    startAuto15[f40] = startAuto151[f40];
                    startAuto16[f40] = startAuto151[f40];

                }
                string output1 = " ";
                string output2 = " ";
                txtResults2.Text = output2;
                txtResults.Text = output1;

                if (f18 == 1)
                {
                    fill_list();
                    f18 = 0;
                }
                repflag = 1;
                f14 = 0;
                f12 = 0;
                loopflag = 0;
                //start  future  loop
                MessageBox.Show("START  of auto scan  mode");

                int f26 = 0;
                int f28 = 0;
                int f30 = 1;
                int flag = 0;

                int f32 = 5;
                int f34 = 0;
                int f36 = 0;
                f38 = 0;
                C22 = 0;

                rflag2 = 1;
                while ((endflag == 0))
                {
                    // MessageBox.Show("Process  has started"); 
                    loopflag++;
                    textBox18.Text = loopflag.ToString();

                    {
                        startAuto151[0] = draws[f38].num1;
                        startAuto151[1] = draws[f38].num2;
                        startAuto151[2] = draws[f38].num3;

                        startAuto151[3] = draws[f38].num4;
                        startAuto151[4] = draws[f38].num5;


                    }

                    if ((f38 < draws.Count - 2) && (rflag2 == 1))
                    {
                        rflag2 = 0;
                        f38++;

                    }
                    else

                        if ((f38 >= draws.Count - 2) && (rflag2 == 1))
                        {
                            rflag2 = 1;
                            endflag = 1;
                            MessageBox.Show("Process  has been completed");
                        }

                    i22 = 0;

                    while ((ret_flag == 1) && (rflag2 == 0))//new  1 or 2 or 3 or 4 or 5 nums in the same  5  code combination...total   6 or 7 or 8 or 9 or 10 nums
                    {

                    start_again:
                        ret_flag = add_nums();


                        if(C22>0)
                        {
                            i22 = comp_history();
                        
                            if (i22 == 1)
                            {
                                i22 = 0;
                                goto start_again;
                            }
                        
                        }
                        



                        for (f112 = 0; f112 < draws.Count; f112++)
                        {

                            for (f42 = 0; f42 < flag_num; f42++)
                            {
                                del2temp15[f42] = del15[f42];
                            }


                            if ((f112 == 100) && (f38 == 101))
                            { }

                            for (c3 = 0; c3 < flag_num; c3++)
                            {

                                if ((startAuto151[c3] == draws[f112].num1 || startAuto151[c3] == draws[f112].num2 || startAuto151[c3] == draws[f112].num3 || startAuto151[c3] == draws[f112].num4 || startAuto151[c3] == draws[f112].num5) && (f38 + 1) != (f112))
                                {
                                    f16++;

                                    del15[c3] = 0;//if hit  a number is reset to 0 in the  win5
                                    numtemp15[c3]++;//counts  the  times a number is hit  in the  win5
                                }
                                else
                                    del15[c3]++;//counts  the  times a number is not  hit

                            }



                            /*   if (((f16 >= win_cnt) && (nbm_loop_count==1))||((f16>=win_cnt) && (c3==0)&&((nbm_loop_count==2)||(nbm_loop_count==3))) ||

                               ((f16>=win_cnt) && (c3 == 1) && ((nbm_loop_count == 4) || (nbm_loop_count == 5))) || ((f16>=win_cnt) && (c3==2) && ((nbm_loop_count==6)||(nbm_loop_count==7)))
                             || ((f16>=win_cnt)  && (c3==3)&&((nbm_loop_count==8)||(nbm_loop_count==9))) || ((f16>=win_cnt) && (c3==4)&&((nbm_loop_count==10)||(nbm_loop_count==11)))

                           || ((f16 >= win_cnt) && (c3 == 5) && ((nbm_loop_count == 12) || (nbm_loop_count == 13))))  */

                            if ((f16 >= win_cnt) && (lock_count_flag == 0) || (f16 >= win_cnt) && (lock_count_flag == 1) && (f22 < (int)numericUpDown17.Value))

                            //modification not  to include     4 winners
                            //if ((f16 > 4)||(f16==4))//modification to include also   4 winners
                            {
                                for (f42 = 0; f42 < flag_num; f42++)
                                {
                                    deltemp15[f42] = del2temp15[f42];
                                    winnum15[f42] = startAuto151[f42];
                                    num15[f42] += numtemp15[f42];//transfer the hit numbers  to display array
                                }
                                f16 = 0;
                                f22++;
                                //  if(f22>17)
                                //  MessageBox.Show("hi   from >17 auto scan");
                                output1 += draws[f112].date2.ToString() + " " + draws[f112].num1.ToString() + " " + draws[f112].num2.ToString() + " " + draws[f112].num3.ToString() + " " + draws[f112].num4.ToString() + " " + draws[f112].num5.ToString() + "       " + draws[f112].joker.ToString() + "\n";

                                win5temp[f22, 0] = draws[f112].num1;
                                win5temp[f22, 1] = draws[f112].num2;
                                win5temp[f22, 2] = draws[f112].num3;
                                win5temp[f22, 3] = draws[f112].num4;
                                win5temp[f22, 4] = draws[f112].num5;
                                //C22++;








                            }

                            for (f41 = 0; f41 < flag_num; f41++)
                            {
                                //deltemp15[f41] = del15[f41];
                                numtemp15[f41] = 0;//zero temporary  array
                            }
                            f16 = 0;
                        }

                        output1 += startAuto151[14].ToString() + "      " + startAuto151[13].ToString() + "      " + startAuto151[12].ToString() + "      " + startAuto151[11].ToString() + "      " + startAuto151[10].ToString() + "      " + startAuto151[9].ToString() + "       " + startAuto151[8].ToString() + "       " + startAuto151[7].ToString() + "       " + startAuto151[6].ToString() + "       " + startAuto151[5].ToString() + "       " + startAuto151[4].ToString() + "       " + startAuto151[3].ToString() + "       " + startAuto151[2].ToString() + "       " + startAuto151[1].ToString() + "       " + startAuto151[0].ToString() + "\n";
                        output1 += deltemp15[14].ToString() + "      " + deltemp15[13].ToString() + "      " + deltemp15[12].ToString() + "      " + deltemp15[11].ToString() + "      " + deltemp15[10].ToString() + "      " + deltemp15[9].ToString() + "      " + deltemp15[8].ToString() + "      " + deltemp15[7].ToString() + "      " + deltemp15[6].ToString() + "      " + deltemp15[5].ToString() + "      " + deltemp15[4].ToString() + "      " + deltemp15[3].ToString() + "      " + deltemp15[2].ToString() + "      " + deltemp15[1].ToString() + "      " + deltemp15[0].ToString() + "\n";

                        //txtResults2.Text = "  ";
                        for (int out2 = 0; out2 < flag_num; out2++)
                        {

                            output2 += startAuto151[out2].ToString() + "      ";
                        }
                        output2 += Convert.ToString(f22) + "\n";






                        for (f41 = 0; f41 < flag_num; f41++)
                        {
                            del2temp15[f41] = 0;
                            del15[f41] = 0;
                            deltemp15[f41] = 0;
                            numpar15[f41] = num15[f41];
                            num15[f41] = 0; //zero  display  array
                        }





                        f23 = f22;

                        //if (f22 >= Convert.ToInt32(textBox16.Text) || loopflag == 5 || loopflag == 8 || loopflag == 11 || loopflag == 14 || loopflag == 17 || loopflag == 20 || loopflag == 23 || loopflag == 26 || loopflag == 29 || loopflag == 32 || loopflag == 35 || loopflag == 38 || loopflag == 41 || loopflag == 45 || loopflag == 48 || loopflag == 51)

                        if (f22 >= Convert.ToInt32(textBox16.Text))



                        // if (f22 >= Convert.ToInt32(textBox16.Text) || loopflag == 5 || loopflag == 8 || loopflag == 11 || loopflag == 14 || loopflag == 17 || loopflag == 20 || loopflag == 23 || loopflag == 26 || loopflag == 29 || loopflag == 32 || loopflag == 35 || loopflag == 38 || loopflag == 41 || loopflag == 45 || loopflag == 48 || loopflag == 51 || loopflag == 54 || loopflag == 57 || loopflag == 60 || loopflag == 63)
                        {
                            tempf61 = f61;
                            tempf21 = f21;
                            tempif21 = startAuto151[f21];
                            tempif61 = startAuto151[f61];
                            winflag = 1;
                            for (f32 = 0; f32 < 5; f32++)
                            {
                                for (f31 = 0; f31 < 300; f31++)
                                {
                                    win5[f31, f32] = win5temp[f31, f32];

                                }
                            }
                            f23 = f22;
                            f22temp = f22;//stores   temporarily  f22 for access in predict method

                            textBox16.Text = Convert.ToString(0);

                            textBox16.Text = Convert.ToString(f22);
                            txtResults.Text = "LEARNING MODE STARTED...... ";

                            //txtResults2.Text = "  ";

                            txtResults.Text = output1;
                            if (Convert.ToInt32(textBox16.Text) >= Convert.ToInt32(textBox21.Text))
                            {
                                C22++;
                                txtResults2.Text += output2;
                                textBox19.Text = Convert.ToString(C22);
                                add_history_7();
                            }



                            for (int a1 = 0; a1 < flag_num; a1++)
                            {
                                winnumfinal15[a1] = winnum15[a1];
                                winnum15[a1] = 0;

                            }

                        }
                        output2 = "";
                        output1 = "";

                        f22 = 0;


                    }


                }


















            }



        }





        public int add_nums()
        {


            int f28 = 1, f26 = 0, flag = 0, f42 = 0, f81 = 0, f27 = 0;
            counter++;
            if (flag_num == 6)
                f26 = 5;
            else if ((flag_num == 7)||(flag_num==8)||(flag_num==9))
            { f26 = 5; f27 = 6; f39 = 7; f905 = 8; }

        cont6:



           



        switch (flag_num)
        {
            case 6:

                
            for (f28 = f30; f28 < 46; f28++)
            {

                if (startAuto151[0] != f28 && startAuto151[1] != f28 && startAuto151[2] != f28 && startAuto151[3] != f28 && startAuto151[4] != f28)
                {
                    startAuto151[f26] = f28;
                    f30 = f28 + 1;
                    flag = 1;
                   
                    if (flag_num == 6)
                        flag1++;
                   



                }




                if ((flag_num == 6) && (flag == 0) && (flag1 <= 40))
                {
                    f30 = f28 + 1;
                    if (flag1 == 40)
                    {
                        f30 = 1;
                        flag1 = 0;
                        rflag2 = 1;

                    }





                    goto cont6;
                }
                if ((flag == 1) && (flag1 <= 40) && (flag_num == 6))
                {
                    //flag = 0;

                    if (flag1 == 40)
                    {
                        f30 = 1;
                        flag1 = 0;
                        rflag2 = 1;

                    }




                    goto exit6;
                }

                if ((flag_num == 6) && (flag1 > 39))
                {

                    f30 = 1;
                    flag1 = 0;
                    rflag2 = 1;
                    goto exit6;
                }
                if (f28 == 27)
                { }
                
            }






                break;


            case 7:

                if(flag4==0)


                {
                    f30 = f128;
                for (f28 = f30; f28 < 46; f28++)
                { 
                    flag2++;

                    if (startAuto151[0] != f28 && startAuto151[1] != f28 && startAuto151[2] != f28 && startAuto151[3] != f28 && startAuto151[4] != f28 && startAuto151[5] != f28 && startAuto151[6] != f28)
                    {
                        startAuto151[f26] = f28;
                        f30 = f28 + 1;
                        flag = 1;

                        
                            
                              
                                flag4 = 1;

                                flag6 = 0;
                                f128 = f30;
                                if ((f128 > 44)&&(f131<45))
                                {
                                  //  rflag2 = 1;
                                   // f128 = 1;
                                    flag4 = 0;
                                    flag6 = 1;
                                }
                                goto cont7;
                            



                    }




               }

        }
                 cont7:

             

              //  f30 = f130;
                for (f130 = f131; f130 < 46; f130++)
                {

                    if (startAuto151[0] != f130 && startAuto151[1] != f130 && startAuto151[2] != f130 && startAuto151[3] != f130 && startAuto151[4] != f130 && startAuto151[5] != f130 && startAuto151[6] != f130)
                    {
                        startAuto151[f27] = f130;
                        
                        // f130 = f30;
                        flag5 = 1;
                       // flag6++;
                        f131 = f130 + 1;
                    }
                     flag3++;

                   if (((f131 > 44)&&(f128<44)&&(flag5==1))||((f131 > 44)&&(f128<44)&&(flag5==0)))
                    {
                        flag5 = 0;
                        flag4 = 0;
                       // rflag2 = 1;
                        f131 = 1;
                        goto exit6;
                    }

                    else
                        if ((flag5 == 1)&&(f131<=44))
                        {
                            flag5 = 0;
                            goto exit6;

                        }
                        else
                            if ((f131 > 43 && f128>43))
                            {
                                flag6 = 0;
                                rflag2 = 1;
                                f131 = 1;
                                f128 = 1;
                                flag4 = 0;
                                flag5 = 0;
                                goto exit6;
                            }

                }


                       
          goto exit6;




                break;



            case 8:


                      if((flag4==0)&&(flag5==0))


                {
                    f30 = f128;
                for (f28 = f30; f28 < 46; f28++)
                {
                   
                    if (startAuto151[0] != f28 && startAuto151[1] != f28 && startAuto151[2] != f28 && startAuto151[3] != f28 && startAuto151[4] != f28 && startAuto151[5] != f28 && startAuto151[6] != f28 && startAuto151[7] != f28)
                    {
                        startAuto151[f26] = f28;
                        f30 = f28 + 1;
                        flag = 1;

                        
                            
                               //flag2++;
                                flag4 = 1;
                                flag6 = 0;
                                f128 = f30;
                                if ((f128 > 44)&&(f131<45))
                                {
                                  //  rflag2 = 1;
                                   // f128 = 1;
                                    flag4 = 0;
                                    flag6 = 1;
                                }
                                 flag2++;
                                goto cont8;
                            



                    }
                    flag2++;
               }

        }
                 cont8:

             if(flag5==0)
             {

              //  f30 = f130;
                for (f130 = f131; f130 < 46; f130++)
                {
                   
                    if (startAuto151[0] != f130 && startAuto151[1] != f130 && startAuto151[2] != f130 && startAuto151[3] != f130 && startAuto151[4] != f130 && startAuto151[5] != f130 && startAuto151[6] != f130 && startAuto151[7] != f130)
                    {
                        startAuto151[f27] = f130;
                        //flag3++;
                        // f130 = f30;
                        flag5 = 1;
                       // flag6++;
                        f131 = f130 + 1;
                        flag108 = 1;
                        flag3++;
                         goto cont81;
                    }
                   

                   if (((f131 > 44)&&(f128<44)&&(flag5==1))||((f131 > 44)&&(f128<44)&&(flag5==0)))
                    {
                        flag5 = 0;
                        flag4 = 0;
                       // rflag2 = 1;
                        f131 = 1;
                        goto exit6;
                    }

                    else
                        if ((flag5 == 1)&&(f131<=44))
                        {
                            flag5 = 0;
                            goto exit6;

                        }
                        else
                            if ((f131 > 43 && f128>43))
                            {
                                flag6 = 0;
                                rflag2 = 1;
                                f131 = 1;
                                f128 = 1;
                                flag4 = 0;
                                flag5 = 0;
                                goto exit6;
                            }
                    flag3++;

                }

        }
                       
         // goto exit6;


        cont81:

          for (f88 = f89; f88 < 46; f88++)
          {
              flag109++;
              if (startAuto151[0] != f88 && startAuto151[1] != f88 && startAuto151[2] != f88 && startAuto151[3] != f88 && startAuto151[4] != f88 && startAuto151[5] != f88 && startAuto151[6] != f88 && startAuto151[7] != f88)
              {
                  startAuto151[f39] = f88;
                  f89 = f88 + 1;
                 // flag = 1;



                  //flag110++;
                  flag10 = 1;
                 // flag6 = 0;
                 // f90 = f89;
                  
                  goto exit6;

}

               

          }







                break;



            case 9:

                  if((flag4==0)&&(flag5==0)&&(flag10==0))


                {
                    f30 = f128;
                for (f28 = f30; f28 < 46; f28++)
                {

                    if (startAuto151[0] != f28 && startAuto151[1] != f28 && startAuto151[2] != f28 && startAuto151[3] != f28 && startAuto151[4] != f28 && startAuto151[5] != f28 && startAuto151[6] != f28 && startAuto151[7] != f28 && startAuto151[8] != f28)
                    {
                        startAuto151[f26] = f28;
                        f30 = f28 + 1;
                        flag = 1;

                        
                            
                               //flag2++;
                                flag4 = 1;
                                flag6 = 0;
                                f128 = f30;
                               
                        /*
                        if ((f128 > 44)&&(f131<45))
                                {
                                  //  rflag2 = 1;
                                   // f128 = 1;
                                    flag4 = 0;
                                    flag6 = 1;
                                }
                          
                         */
                                flag2++;
                                goto cont9;
                            



                    }
                    flag2++;
               }

                if (flag2 >= 45)
                {
                    f128 = 1;
                    // f89 = 1;
                    // flag5 = 0;
                    //  flag4 = 0;
                    // flag109 = 0;
                    // rflag2 = 1;
                    flag2 = 0;
                    flag3 = 0;
                    flag6 = 0;
                    //flag902 = 0;
                    rflag2 = 1;
                    flag10 = 0;
                   
                    flag2 = 0;

                    f30 = 1;
                goto exit9;
                }
        }
                 cont9:

             if((flag5==0)&&(flag10==0))
             {

              //  f30 = f130;
                for (f130 = f131; f130 < 46; f130++)
                {

                    if (startAuto151[0] != f130 && startAuto151[1] != f130 && startAuto151[2] != f130 && startAuto151[3] != f130 && startAuto151[4] != f130 && startAuto151[5] != f130 && startAuto151[6] != f130 && startAuto151[7] != f130 && startAuto151[8] != f130)
                    {
                        startAuto151[f27] = f130;
                        //flag3++;
                        // f130 = f30;
                        flag5 = 1;
                       // flag6++;
                        f131 = f130 + 1;
                        flag108 = 1;
                        flag3++;
                         goto cont91;
                    }
                   
 

                   
                      
                    flag3++;

                }

                 /*
                if ((flag2 >= 45)&&(flag3>=45))
                {
                    f128 = 1;
                    // f89 = 1;
                    // flag5 = 0;
                    //  flag4 = 0;
                    // flag109 = 0;
                    // rflag2 = 1;
                    flag2 = 0;
                    flag3 = 0;
                    flag6 = 0;
                    //flag902 = 0;
                   // rflag2 = 1;
                    flag10 = 0;
                    f131 = 1;
                    flag5 = 0;
                    flag2 = 0;

                    f30 = 1;
                    goto exit9;
                }

                 */




        }
                       
         // goto exit6;


        cont91:

                  if (flag10 == 0)
                  {

                      for (f88 = f89; f88 < 46; f88++)
                      {
                         
                          if (startAuto151[0] != f88 && startAuto151[1] != f88 && startAuto151[2] != f88 && startAuto151[3] != f88 && startAuto151[4] != f88 && startAuto151[5] != f88 && startAuto151[6] != f88 && startAuto151[7] != f88 && startAuto151[8] != f88)
                          {
                              startAuto151[f39] = f88;
                              f89 = f88 + 1;
                              // flag = 1;



                              //flag110++;
                              flag10 = 1;
                              // flag6 = 0;
                              // f90 = f89;
                              flag109++;
                              goto cont92;

                          }

                          flag109++;

                      }
                  }
        cont92:

                  for (f900 = f901; f900 < 46; f900++)
                  {
                     
                      if (startAuto151[0] != f900 && startAuto151[1] != f900 && startAuto151[2] != f900 && startAuto151[3] != f900 && startAuto151[4] != f900 && startAuto151[5] != f900 && startAuto151[6] != f900 && startAuto151[7] != f900 && startAuto151[8] != f900 )
                      {
                          startAuto151[f905] = f900;
                          f901 = f900 + 1;
                          // flag = 1;



                          //flag110++;
                          flag903 = 1;
                          // flag6 = 0;
                          // f90 = f89;
                            flag902++;
                          goto exit6;

                      }

                      flag902++;

                  }








                break;

            default:
                break;

        }

           






        


 goto exit6;



                /*
                if ((flag_num == 6) && (counter == 1) || (flag_num == 7) && (counter == 1) || (flag_num == 8) && (counter == 1) || (flag_num == 9) && (counter == 1) || (flag_num == 10) && (counter == 1))
                        {
                        f312 = f26-1;}

                        else
                    if (  (flag_num == 7) && (counter == 2) || (flag_num == 8) && (counter == 2) || (flag_num == 9) && (counter == 2) || (flag_num == 10) && (counter == 2))
                            {
                                f312 = f26 - 1;
                            }

                    else
                        if (  (flag_num == 8) && (counter == 3) || (flag_num == 9) && (counter == 3) || (flag_num == 10) && (counter == 3))
                        {
                            f312 = f26 - 1;
                        }

                        else
                            if (  (flag_num == 9) && (counter == 4) || (flag_num == 10) && (counter == 4))
                            {
                                f312 = f26 - 1;
                            }

                            else
                                if ( (flag_num == 10) && (counter == 5))
                                {
                                    f312 = f26 - 1;
                                }

                        */


                /*  if ((f28 == 46) && (f26 == flag_num))
                  {
                      f312 = 5;
                      f42 = 0;
                      counter = 0;

                  }
                 */

 exit6:
/* if ((flag4 == 0 && flag6 == 1) && (f130 > 43))
 {
     f128 = 1;
     flag6 = 0;
     rflag2 = 1;

     rflag2 = 1;
     f131 = 1;
     f128 = 1;
     flag4 = 0;
     flag5 = 0;


 }
 */
// if (f38 ==164)
 //{
 //}

// if ((flag_num == 8) && (flag109 >= 45)&&(flag3<45)&&(flag2<45))

 if ((flag_num == 9) && (flag109 <= 45) && (flag902 >= 45) && (flag3 <= 47) && (flag2 <= 46))

 //if ((flag_num == 9) && (flag902 >= 45))

 {
    // f89 = 1;
     //flag109 = 0;
    // flag5 = 0;
     flag902 = 0;
    // flag901 = 1;
     flag10 = 0;
     f901 = 1;
 }






 if ((flag_num == 9) && (flag109 >= 45) && (flag3 <= 45) && (flag902 >= 45) && (flag2 <= 46))
 {
     f901 = 1;
     f89 = 1;
     flag109 = 0;
     flag5 = 0;
     flag902 = 0;
   //  flag901 = 1;
     flag10 = 0;
    // f89 = 1;
     //flag5 = 0;
 }
 if ((flag_num == 9) && (flag109 >= 45) && (flag3 >= 45) && (flag2 <= 45) && (flag902 >= 45))
 {
    f901 = 1;
     f131 = 1;
     f89 = 1;
     flag5 = 0;
     flag4 = 0;
    // flag109 = 0;
     flag3 = 0;
    // flag902 = 0;
    // f89 = 1;
     flag109 = 0;
    // flag5 = 0;
     flag902 = 0;
     flag901 = 1;
     flag10 = 0;

 }

 if ((flag_num == 9) && (flag109 >= 45) && (flag3 >= 45) && (flag2 >= 45)&&(flag902>=45))
 {
     f901 = 1;
     f131 = 1;
     f89 = 1;
     flag5 = 0;
     flag4 = 0;
     flag109 = 0;
     flag3 = 0;
     flag902 = 0;
     f89 = 1;
     flag109 = 0;
     flag5 = 0;
     flag902 = 0;
   //  flag901 = 1;
     flag10 = 0;




    // f131 = 1;
     f128 = 1;
    // f89 = 1;
    // flag5 = 0;
   //  flag4 = 0;
    // flag109 = 0;
    // rflag2 = 1;
     flag2 = 0;
     flag3 = 0;
     flag6 = 0;
     //flag902 = 0;
 rflag2 = 1;
 //flag10 = 0;
 }


       /*     
            if ((flag_num == 9) && (flag109 >= 45) && (flag3 >= 45) && (flag2 >= 45) && (flag902 >= 45))
 {
     f131 = 1;
     f128 = 1;
     f89 = 1;
     flag5 = 0;
     flag4 = 0;
     flag109 = 0;
     flag10 = 0;
     flag2 = 0;
     flag3 = 0;
     flag6 = 0;
     flag902 = 0;
 }

            */





 if ((flag_num == 8) && (flag109 >= 45) && (flag3 < 45))
 {
     f89 = 1;
     flag109 = 0;
     flag5 = 0;
 }
 if ((flag_num == 8) && (flag109 >= 45)&&(flag3>=45)&&(flag2<45))
 {
     f131 = 1;
     f89 = 1;
     flag5 = 0;
     flag4 = 0;
     flag109 = 0;
     flag3 = 0;
 }

 if ((flag_num == 8) && (flag109 >= 45)&&(flag3>=45)&&(flag2>=45))
 {
     f131 = 1;
     f128 = 1;
     f89 = 1;
     flag5 = 0;
     flag4 = 0;
     flag109 = 0;
     rflag2 = 1;
     flag2 = 0;
     flag3 = 0;
     flag6 = 0;
 }



 if ((flag_num==7)&&(flag3 >=45)&&(flag2<45))
 {

     flag3 = 0;
     flag5 = 0;
     f131 = 1;
     flag4 = 0;
 }
 
   if ((flag_num==7)&&(flag2>=45  && flag3>=45))
     { f131 = 1;
     f128 = 1;
     flag4 = 0;
     flag2 = 0;
     flag3 = 0;
     rflag2 = 1;
     flag5 = 0;
     flag6 = 0;
     }

  // if (f38 > 161)
   //{
   //}
            exit9:
           f42 = 1;
            return f42;


            }

       

        }

    


        public class draw1
        {
            
            public int drawcount = 0;
            public int diff_delta;
            public int index;
            public DateTime date2;
            public int joker;
            public int num1;
            public int num2;
            public int num3;
            public int num4;
            public int num5;
            public int del1;
            public int del2;
            public int del3;
            public int del4;
            public int del5;
            public int sumdel;
            public int sumoccur;
            public int occur1;
            public int occur2;
            public int occur3;
            public int occur4;
            public int occur5;
            public int sumavroccur;
            public int avroccur;
            public int eoccur0;
            public int eoccur1;
            public int eoccur2;
            public int eoccur3;
            public int eoccur4;
            public int eoccur5;
            public int[] nums_del_array = new int[45];
            public int[] nums_occur_array = new int[45];
            // int occurances;
            int avr12;
            int avr13;
            int avr14;
            int avr15;
            int avr23;
            int avr24;
            int avr25;
            int avr34;
            int avr35;
            int avr45;
            int avr123;
            int avr124;
            int avr125;
            int avr145;
            int avr135;
            int avr134;
            int avr234;
            int avr235;
            int avr245;
            int avr345;


            int avr1234;
            int avr1235;
            int avr2345;
            int avr1245;
            int avr1345;
            int avr12345;
            int e50;//evens/odds 5/0,4/1,3/2,2/3,1/4,0/5  
            public int num1_occur;
            public int num1_del;
            public int num2_occur;
            public int num2_del;
            public int num3_occur;
            public int num3_del;
            public int num4_occur;
            public int num4_del;
            public int num5_occur;
            public int num5_del;
            public int num6_occur;
            public int num6_del;
            public int num7_occur;
            public int num7_del;
            public int num8_occur;
            public int num8_del;
            public int num9_occur;
            public int num9_del;
            public int num10_occur;
            public int num10_del;
            public int num11_occur;
            public int num11_del;
            public int num12_occur;
            public int num12_del;
            public int num13_occur;
            public int num13_del;
            public int num14_occur;
            public int num14_del;
            public int num15_occur;
            public int num15_del;
            public int num16_occur;
            public int num16_del;
            public int num17_occur;
            public int num17_del;
            public int num18_occur;
            public int num18_del;
            public int num19_occur;
            public int num19_del;
            public int num20_occur;
            public int num20_del;
            public int num21_occur;
            public int num21_del;
            public int num22_occur;
            public int num22_del;
            public int num23_occur;
            public int num23_del;
            public int num24_occur;
            public int num24_del;
            public int num25_occur;
            public int num25_del;
            public int num26_occur;
            public int num26_del;
            public int num27_occur;
            public int num27_del;
            public int num28_occur;
            public int num28_del;
            public int num29_occur;
            public int num29_del;
            public int num30_occur;
            public int num30_del;
            public int num31_occur;
            public int num31_del;
            public int num32_occur;
            public int num32_del;
            public int num33_occur;
            public int num33_del;
            public int num34_occur;
            public int num34_del;
            public int num35_occur;
            public int num35_del;
            public int num36_occur;
            public int num36_del;
            public int num37_occur;
            public int num37_del;
            public int num38_occur;
            public int num38_del;
            public int num39_occur;
            public int num39_del;
            public int num40_occur;
            public int num40_del;
            public int num41_occur;
            public int num41_del;
            public int num42_occur;
            public int num42_del;
            public int num43_occur;
            public int num43_del;
            public int num44_occur;
            public int num44_del;
            public int num45_occur;
            public int num45_del;
            //differences  num2-num1,num3-num1,num4-num1,num5-num1,num3-num2,num4-num2,num5-num2,num4-num3,num5-num3,num5-num4.

            int diff21, diff31, diff41, diff51, diff32, diff42, diff52, diff43, diff53, diff54;



            public draw1(DateTime date2, int index, int jok, int a1, int a2, int a3, int a4, int a5, int o1, int d1, int o2, int d2, int o3, int d3, int o4, int d4, int o5, int d5, int e0, int e1, int e2, int e3, int e4, int e5, int avroc1, int n1_del, int n2_del, int n3_del, int n4_del, int n5_del, int n6_del, int n7_del, int n8_del, int n9_del, int n10_del, int n11_del, int n12_del, int n13_del, int n14_del, int n15_del, int n16_del, int n17_del, int n18_del, int n19_del, int n20_del, int n21_del, int n22_del, int n23_del, int n24_del, int n25_del, int n26_del, int n27_del, int n28_del, int n29_del, int n30_del, int n31_del, int n32_del, int n33_del, int n34_del, int n35_del, int n36_del, int n37_del, int n38_del, int n39_del, int n40_del, int n41_del, int n42_del, int n43_del, int n44_del, int n45_del, int n1_occur, int n2_occur, int n3_occur, int n4_occur, int n5_occur, int n6_occur, int n7_occur, int n8_occur, int n9_occur, int n10_occur, int n11_occur, int n12_occur, int n13_occur, int n14_occur, int n15_occur, int n16_occur, int n17_occur, int n18_occur, int n19_occur, int n20_occur, int n21_occur, int n22_occur, int n23_occur, int n24_occur, int n25_occur, int n26_occur, int n27_occur, int n28_occur, int n29_occur, int n30_occur, int n31_occur, int n32_occur, int n33_occur, int n34_occur, int n35_occur, int n36_occur, int n37_occur, int n38_occur, int n39_occur, int n40_occur, int n41_occur, int n42_occur, int n43_occur, int n44_occur, int n45_occur)
            {
            this.date2 = date2;
            this.index = index;
                
                joker = jok;
                num1 = a1;
                num2 = a2;
                num3 = a3;
                num4 = a4;
                num5 = a5;
                avr12345 = (a1 + a2 + a3 + a4 + a5) / 5;
                avr1234 = (a1 + a2 + a3 + a4) / 4;
                avr1345 = (a1 + a3 + a4 + a5) / 4;
                avr2345 = (a2 + a3 + a4 + a5) / 4;
                avr1245 = (a1 + a2 + a4 + a4) / 4;
                avr1235 = (a1 + a2 + a3 + a5) / 4;
                avr234 = (a2 + a3 + a4) / 3;
                avr345 = (a3 + a4 + a5) / 3;
                avr134 = (a1 + a3 + a4) / 3;
                avr145 = (a1 + a4 + a5) / 3;
                avr235 = (a2 + a3 + a5) / 3;
                avr135 = (a1 + a3 + a5) / 3;
                avr125 = (a1 + a2 + a5) / 3;
                avr124 = (a1 + a2 + a4) / 3;
                avr245 = (a2 + a4 + a5) / 3;
                avr123 = (a1 + a2 + a3) / 3;
                avr12 = (a1 + a2) / 2;
                avr13 = (a1 + a3) / 2;

                avr14 = (a1 + a4) / 2;
                avr15 = (a1 + a5) / 2;
                avr23 = (a3 + a2) / 2;
                avr24 = (a4 + a2) / 2;
                avr25 = (a5 + a2) / 2;
                avr34 = (a3 + a4) / 2;
                avr35 = (a3 + a5) / 2;
                avr45 = (a4 + a5) / 2;
                //differences  num2-num1,num3-num1,num4-num1,num5-num1,num3-num2,num4-num2,num5-num2,num4-num3,num5-num3,num5-num4.
                diff_delta = num1;
                diff21 = num2 - num1;
                diff31 = num3 - num1;
                diff41 = num4 - num1;
                diff51 = num5 - num1;
                diff32 = num3 - num2;
                diff42 = num4 - num2;
                diff52 = num5 - num2;
                diff43 = num4 - num3;
                diff53 = num5 - num3;
                diff54 = num5 - num4;



                occur1 = o1;
                del1 = d1;
                occur2 = o2;
                del2 = d2;
                occur3 = o3;
                del3 = d3;
                occur4 = o4;
                del4 = d4;
                occur5 = o5;
                del5 = d5;
                drawcount++;
                sumdel = del1 + del2 + del3 + del4 + del5;
                sumoccur = occur1 + occur2 + occur3 + occur4 + occur5;
                sumavroccur = 5 * avroc1;
                eoccur0 = e0;
                eoccur1 = e1;
                eoccur2 = e2;
                eoccur3 = e3;
                eoccur4 = e4;
                eoccur5 = e5;
                if (a1 % 2 == 0)
                    e50++;
                if (a2 % 2 == 0)
                    e50++;

                if (a3 % 2 == 0)
                    e50++;
                if (a4 % 2 == 0)
                    e50++;

                if (a5 % 2 == 0)
                    e50++;

                avroccur = avroc1;

                num1_occur = n1_occur;
                num1_del = n1_del;
                nums_del_array[0] = n1_del;
                nums_occur_array[0] = n1_occur;
                num2_occur = n2_occur;
                num2_del = n2_del;
                nums_del_array[1] = n2_del;
                nums_occur_array[1] = n2_occur;

                num3_occur = n3_occur;
                num3_del = n3_del;
                nums_del_array[2] = n3_del;
                nums_occur_array[2] = n3_occur;

                num4_occur = n4_occur;
                num4_del = n4_del;
                nums_del_array[3] = n4_del;
                nums_occur_array[3] = n4_occur;

                num5_occur = n5_occur;
                num5_del = n5_del;

                nums_del_array[4] = n5_del;
                nums_occur_array[4] = n5_occur;
                num6_occur = n6_occur;
                num6_del = n6_del;
                nums_del_array[5] = n6_del;
                nums_occur_array[5] = n6_occur;
                num7_occur = n7_occur;
                num7_del = n7_del;
                nums_del_array[6] = n7_del;
                nums_occur_array[6] = n7_occur;
                num8_occur = n8_occur;
                num8_del = n8_del;
                nums_del_array[7] = n8_del;
                nums_occur_array[7] = n8_occur;
                num9_occur = n9_occur;
                num9_del = n9_del;
                nums_del_array[8] = n9_del;
                nums_occur_array[8] = n9_occur;
                num10_occur = n10_occur;
                num10_del = n10_del;
                nums_del_array[9] = n10_del;
                nums_occur_array[9] = n10_occur;
                num11_occur = n11_occur;
                num11_del = n11_del;
                nums_del_array[10] = n11_del;
                nums_occur_array[10] = n11_occur;
                num12_occur = n12_occur;
                num12_del = n12_del;
                nums_del_array[11] = n12_del;
                nums_occur_array[11] = n12_occur;
                num13_occur = n13_occur;
                num13_del = n13_del;
                nums_del_array[12] = n13_del;
                nums_occur_array[12] = n13_occur;
                num14_occur = n14_occur;
                num14_del = n14_del;
                nums_del_array[13] = n14_del;
                nums_occur_array[13] = n14_occur;
                num15_occur = n15_occur;
                num15_del = n15_del;
                nums_del_array[14] = n15_del;
                nums_occur_array[14] = n15_occur;
                num16_occur = n16_occur;
                num16_del = n16_del;
                nums_del_array[15] = n16_del;
                nums_occur_array[15] = n16_occur;
                num17_occur = n17_occur;
                num17_del = n17_del;
                nums_del_array[16] = n17_del;
                nums_occur_array[16] = n17_occur;
                num18_occur = n18_occur;
                num18_del = n18_del;
                nums_del_array[17] = n18_del;
                nums_occur_array[17] = n18_occur;
                num19_occur = n19_occur;
                num19_del = n19_del;
                nums_del_array[18] = n19_del;
                nums_occur_array[18] = n19_occur;
                num20_occur = n20_occur;
                num20_del = n20_del;
                nums_del_array[19] = n20_del;
                nums_occur_array[19] = n20_occur;
                num21_occur = n21_occur;
                num21_del = n21_del;
                nums_del_array[20] = n21_del;
                nums_occur_array[20] = n21_occur;
                num22_occur = n22_occur;
                num22_del = n22_del;
                nums_del_array[21] = n22_del;
                nums_occur_array[21] = n22_occur;
                num23_occur = n23_occur;
                num23_del = n23_del;
                nums_del_array[22] = n23_del;
                nums_occur_array[22] = n23_occur;
                num24_occur = n24_occur;
                num24_del = n24_del;
                nums_del_array[23] = n24_del;
                nums_occur_array[23] = n24_occur;
                num25_occur = n25_occur;
                num25_del = n25_del;
                nums_del_array[24] = n25_del;
                nums_occur_array[24] = n25_occur;
                num26_occur = n26_occur;
                num26_del = n26_del;
                nums_del_array[25] = n26_del;
                nums_occur_array[25] = n26_occur;
                num27_occur = n27_occur;
                num27_del = n27_del;
                nums_del_array[26] = n27_del;
                nums_occur_array[26] = n27_occur;
                num28_occur = n28_occur;
                num28_del = n28_del;
                nums_del_array[27] = n28_del;
                nums_occur_array[27] = n28_occur;
                num29_occur = n29_occur;
                num29_del = n29_del;
                nums_del_array[28] = n29_del;
                nums_occur_array[28] = n29_occur;
                num30_occur = n30_occur;
                num30_del = n30_del;
                nums_del_array[29] = n30_del;
                nums_occur_array[29] = n30_occur;
                num31_occur = n31_occur;
                num31_del = n31_del;
                nums_del_array[30] = n31_del;
                nums_occur_array[30] = n31_occur;
                num32_occur = n32_occur;
                num32_del = n32_del;
                nums_del_array[31] = n32_del;
                nums_occur_array[31] = n32_occur;
                num33_occur = n33_occur;
                num33_del = n33_del;
                nums_del_array[32] = n33_del;
                nums_occur_array[32] = n33_occur;
                num34_occur = n34_occur;
                num34_del = n34_del;
                nums_del_array[33] = n34_del;
                nums_occur_array[33] = n34_occur;
                num35_occur = n35_occur;
                num35_del = n35_del;
                nums_del_array[34] = n35_del;
                nums_occur_array[34] = n35_occur;
                num36_occur = n36_occur;
                num36_del = n36_del;
                nums_del_array[35] = n36_del;
                nums_occur_array[35] = n36_occur;
                num37_occur = n37_occur;
                num37_del = n37_del;
                nums_del_array[36] = n37_del;
                nums_occur_array[36] = n37_occur;
                num38_occur = n38_occur;
                num38_del = n38_del;
                nums_del_array[37] = n38_del;
                nums_occur_array[37] = n38_occur;
                num39_occur = n39_occur;
                num39_del = n39_del;
                nums_del_array[38] = n39_del;
                nums_occur_array[38] = n39_occur;
                num40_occur = n40_occur;
                num40_del = n40_del;
                nums_del_array[39] = n40_del;
                nums_occur_array[39] = n40_occur;
                num41_occur = n41_occur;
                num41_del = n41_del;
                nums_del_array[40] = n41_del;
                nums_occur_array[40] = n41_occur;
                num42_occur = n42_occur;
                num42_del = n42_del;
                nums_del_array[41] = n42_del;
                nums_occur_array[41] = n42_occur;
                num43_occur = n43_occur;
                num43_del = n43_del;
                nums_del_array[42] = n43_del;
                nums_occur_array[42] = n43_occur;
                num44_occur = n44_occur;
                num44_del = n44_del;
                nums_del_array[43] = n44_del;
                nums_occur_array[43] = n44_occur;
                num45_occur = n45_occur;
                num45_del = n45_del;

                nums_del_array[44] = n45_del;
                nums_occur_array[44] = n45_occur;





            }







        }
        














        public class test1
        {
            public test1()
            {
                //ri4=34;
            }
            public void test2()
            {


            }


        }



    }

