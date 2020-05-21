class Header extends React.Component {
    <nav className="navbar navbar-light navbar-expand-md">
    <div className="container-fluid"><a className="navbar-brand" href="#">Brand</a>
        <ul className="nav navbar-nav">
            <li className="nav-item" role="presentation"><a className="nav-link active" href="#">First Item</a></li>
            <li className="nav-item" role="presentation"><a className="nav-link" href="#">Second Item</a></li>
            <li className="nav-item" role="presentation"><a className="nav-link" href="#">Third Item</a></li>
        </ul><button data-toggle="collapse" data-target="#navcol-1" className="navbar-toggler"><span className="sr-only">Toggle navigation</span><span className="navbar-toggler-icon"></span></button>
        <div className="collapse navbar-collapse" id="navcol-1">
            <ul className="nav navbar-nav">
                <li role="presentation" className="nav-item"><a className="nav-link active" href="#">First Item</a></li>
                <li role="presentation" className="nav-item"><a className="nav-link" href="#">Second Item</a></li>
                <li role="presentation" className="nav-item"><a className="nav-link" href="#">Third Item</a></li>
            </ul>
        </div>
    </div>
</nav>
}