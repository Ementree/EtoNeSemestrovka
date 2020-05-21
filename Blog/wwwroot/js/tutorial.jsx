class RegistrationForm extends React.Component {
    render() {
        return (			
			<div className="form-container">
				<form method="post" asp-controller="Account" asp-action="Register">
					<div asp-validation-summary="ModelOnly"></div>
					<h2 className="text-center"><strong>Create</strong> an account.</h2>
					<div className="form-group">
						<input className="form-control" placeholder="UserName" asp-for="Username" />
						<span asp-validation-for="Username"></span>
					</div>
					<div className="form-group">
						<input className="form-control" placeholder="Email" asp-for="Email" />
						<span asp-validation-for="Email"></span>
					</div>
					<div className="form-group">
						<input className="form-control" placeholder="Password" asp-for="Password" />
						<span asp-validation-for="Password"></span>
					</div>				
					<div className="form-group">
						<input className="btn btn-primary btn-block" type="submit" value="Register" />
					</div>
				</form>
			</div>
        );
    }
}

ReactDOM.render(<RegistrationForm />, document.getElementById('content'));