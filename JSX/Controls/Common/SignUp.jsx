
var React = require('react');
var forms = require('../../../node_modules/newforms');
var BootstrapForm = require('../../../node_modules/newforms-bootstrap');

var SignUpForm = forms.Form.extend({
    UserName: forms.CharField(),
    Email: forms.EmailField(),
    Password: forms.CharField({ widget: forms.PasswordInput }),
    ConfirmPassword: forms.CharField({ widget: forms.PasswordInput }),
    AcceptTerms: forms.BooleanField({ required: true })
});

var SignUp = React.createClass({

    propTypes: {
        initialData: React.PropTypes.object,
        postbackURL: React.PropTypes.string,
    },

    getInitialState() {
        return {
            form: new SignUpForm({
                controlled: true,
                initial: this.props.initialData,
                onChange: this.forceUpdate.bind(this)
            })
        }
    },

    _onSubmit(e) {
        var form = this.refs.signupForm.getForm()
        var isValid = form.validate()
        if (isValid) {
            console.log(JSON.stringify(form.cleanedData));
            //Helpers.showInfoMessage("It worked, check the log for details...");

        } else {
            e.preventDefault()
        }
    },

    render: function () {
        return <form method="post" onSubmit={this._onSubmit} action={this.props.postbackURL}>
          <forms.RenderForm form={this.state.form} ref="signupForm">
              <BootstrapForm />
          </forms.RenderForm>
          <input type="submit" className="btn btn-success" value="Sign Up" />
        </form>
    }
});

module.exports = SignUp;