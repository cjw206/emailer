<template>
  <div>
    <div>
    <h2>Send an Email</h2>
    </div>
    <div>
      <b-form-group
      id="fieldsetHorizontal"
      horizontal
      :label-cols="4"
      label=""
      label-for="input1"
      :invalid-feedback="invalidFeedback"
      :valid-feedback="validFeedback"
      :state="state"
  >
    <b-col sm="6"><b-form-input id="input1" :state="state" placeholder="Enter email address." type="email" v-model="Email.To"></b-form-input></b-col>
    <b-col sm="6"><b-form-input id="input2" :state="state" placeholder="Enter subject line." type="text" v-model="Email.Subject"></b-form-input></b-col>
    <b-col sm="6">
    <b-form-textarea id="textarea1"
                    v-model="Email.Body"
                    placeholder="Enter email body."
                    :rows="3"
                    :max-rows="6">
    </b-form-textarea>
     </b-col>
     <b-col sm="6"><b-button v-on:click="sendEmail()">Send Email</b-button></b-col>
  </b-form-group>

    </div>
  </div>
</template>

<script>
import axios from 'axios'

export default {
  name: 'Email',
  data () {
    return {
      Email: {},
      Confirmation: ''
    }
  },
  methods: {
    sendEmail: function () {
      this.Email.From = 'mailer@emailapp.com'
      axios.post('http://localhost:5000/api/email/send', this.Email)
      .then((response) => {
        this.Confirmation = response.data.value
      }, (error) => {
        this.Confirmation = error
      })
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h1, h2 {
  font-weight: normal;
}

ul {
  list-style-type: none;
  padding: 0;
}

li {
  display: inline-block;
  margin: 0 10px;
}

a {
  color: #42b983;
}
</style>
