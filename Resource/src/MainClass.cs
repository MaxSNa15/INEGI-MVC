using INEGI.src.controllers;
using INEGI.src.databases;
using INEGI.src.models;
using INEGI.src.views;

namespace INEGI.src
{
    static class MainClass
    {   
        [STAThread]
        static void Main()
        {
            ModelUser mdUsuer = new ModelUser();
            FrmLogin vwLogin = new FrmLogin();
            QueryUser qyUser = new QueryUser();
            ControllerLogin ctLogin = new ControllerLogin(qyUser ,mdUsuer, vwLogin);
            ctLogin.RunApp();
        }
    }
}