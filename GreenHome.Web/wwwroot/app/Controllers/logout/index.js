var logoutController = function () {
    this.initialize = function () {
        registerEvents();
    }

    var registerEvents = function () {
        
        $('#btnLogout').on('click', function (e) {
            logout();
        });
    }


    var logout = function () {
        $.ajax({
            type: 'POST',
          
            dateType: 'json',
            url: '/admin/account/logout',
            success: function (res) {
                if (res.Success) {
                    window.location.href = "/Admin/Login";
                }
                else {
                    cuong.notify('log out failed', 'error');
                }
            }
        })
    }
    
}