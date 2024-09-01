using Injection_Test2;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject2
{
    public class Form1Tests
    {

        [Fact]
        public void Inloggning_WithValidUser_UpdatesStatusLabelToLoggedIn()
        {
            // Arrange
            var mockDatabaseService = new Mock<IDatabaseService>();
            mockDatabaseService.Setup(ds => ds.ValidateUser(It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            var form = new Form1(mockDatabaseService.Object);


            var txtUser = (TextBox)form.Controls.Find("txtUser", true)[0];
            var txtPass = (TextBox)form.Controls.Find("txtPass", true)[0];
            var lblStatus = (Label)form.Controls.Find("lblStatus", true)[0];


            txtUser.Text = "validUser";
            txtPass.Text = "validPass";

            // Act
            form.Inloggning();

            // Assert
            Assert.Equal("Du har loggat in", lblStatus.Text);
        }
        [Fact]
        public void Inloggning_WithInvalidUser_UpdatesStatusLabelToLoggedOut()
        {
            // Arrange
            var mockDatabaseService = new Mock<IDatabaseService>();

            mockDatabaseService.Setup(ds => ds.ValidateUser(It.IsAny<string>(), It.IsAny<string>())).Returns(false);


            var form = new Form1(mockDatabaseService.Object);

            var txtUser = new TextBox { Name = "txtUser", Text = "invalidUser" };
            var txtPass = new TextBox { Name = "txtPass", Text = "invalidPass" };
            var lblStatus = new Label { Name = "lblStatus" };


            form.Controls.Add(txtUser);
            form.Controls.Add(txtPass);
            form.Controls.Add(lblStatus);


            form.Controls["txtUser"].Text = txtUser.Text;
            form.Controls["txtPass"].Text = txtPass.Text;
            form.Controls["lblStatus"].Text = lblStatus.Text;

            // Act
            form.Inloggning();

            // Assert
            Assert.Equal("Du är utloggad", form.Controls["lblStatus"].Text);
        }
    }
}
