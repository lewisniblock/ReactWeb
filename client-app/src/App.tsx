import React, { Component } from "react";
import logo from "./logo.svg";
import "./App.css";
import { Header, Icon, List } from "semantic-ui-react";

class App extends Component {
  state = {
    values: [],
  };

  componentDidMount() {
    this.setState({
      values: [
        { id: 1, name: "Value 101 bro" },
        { id: 2, name: "Value 202 dude" },
      ],
    });
  }

  render() {
    return (
      <div>
        <Header as="h2">
          <Icon name="users" />
          <Header.Content>LewisHR</Header.Content>
        </Header>
        <List>
          {this.state.values.map((p: any) => (
              <List.Item key={p.id}>{p.name}</List.Item>
          ))}
            </List>
      </div>
    );
  }
}

export default App;
