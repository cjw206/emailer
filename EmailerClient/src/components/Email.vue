<template>
  <div class="Email">
    <div>
    <h2>Send an Email</h2>
    </div>
    <div>
      <b-form-group
      id="fieldsetHorizontal"
      horizontal
      :label-cols="4"
      label="Enter your email."
      label-for="input1"
      :invalid-feedback="invalidFeedback"
      :valid-feedback="validFeedback"
      :state="state"
  >
    <b-col sm="6"><b-form-input id="input1" :state="state" type="email" v-model.trim="name"></b-form-input></b-col>
  </b-form-group>

    </div>
  </div>
</template>

<script>
export default {
  name: 'Email',
  data () {
    return {
      msg: 'Welcome to Your Vue.js App'
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
