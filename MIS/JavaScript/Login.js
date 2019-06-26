$(function () {
    makeName();
    makePwd();
    makeLogin();

    //登陆事件
    $("#btnLogin").click(function () {
        var name = $("#Name").val();
        var pwd = $("#Pwd").val();
        if (name=="") {
            $.messager.alert("温馨提示", "请输入用户名！！！", "info");
            return;
        }
        if (pwd == "") {
            $.messager.alert("温馨提示", "请输入密码！！！", "info");
            return;
        }

        $("#btnLogin").ajax({
            type: 'POST',
            dataType:'json',
            url: '/Ashx/login.ashx?Method=' + isLogin,
            data: 'name='+name+"&pwd="+pwd,
            success: function (data) {
                console.info(data);
            },
            error: function (erro) {
                console.info(erro);
            }
        });

    });



});

function makeName() {
    $("#Name").textbox({
        iconCls: 'icon-man',
        iconAlign: 'left'
    });
}

function makePwd() {
    $("#Pwd").textbox({
        iconCls: 'icon-lock',
        iconAlign: 'left'
    });
}

function makeLogin() {
    $("#btnLogin").linkbutton({
        iconCls: 'icon-login',
        plain:true,
    });
}




